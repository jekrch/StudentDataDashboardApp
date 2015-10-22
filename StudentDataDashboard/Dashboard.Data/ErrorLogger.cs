using System;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows;
using PFdata.Dashboard.Models;

namespace PFdata.Dashboard.Data
{
    internal class ErrorLogger
    {

        private static string ErrorLog(Exception ex)
        {
            var line = new string('-', 90);

            string userMessage = null;

            if (App.Current.Properties["UserMessage"] != null)
            {
                var Msg = (UserMsg) App.Current.Properties["UserMessage"];
                userMessage = line +
                              "\n\nName:   " + Msg.Name +
                              "\n\nEmail:   " + Msg.Email +
                              "\n\nMessage: \n\n" + Msg.MessageText +
                              "\n\n";
            }

            return userMessage + line +
                   "\n\nDate: \n\t" + DateTime.Now +
                   "\n\nFile: \n\t" + MainWindow.FilePath +
                   "\n\nMessage: \n\t" + ex.Message +
                   "\n\nSource: \n\t" + ex.Source +
                   "\n\nTarget Site: \n\t" + ex.TargetSite +
                   "\n\nData: \n\t" + ex.Data +
                   "\n\nInner Exception: \n\t" + ex.InnerException +
                   "\n\nStackTrace: \n" + ex.StackTrace + "\n\n" +
                   line +
                   "\n\nSYSTEM INFORMATION" +
                   "\n\nOS: \n\t" + Environment.OSVersion +
                   "\n\nProcessor Count: \n\t" + Environment.ProcessorCount +
                   "\n\nSystem Page Size: \n\t" + Environment.SystemPageSize + "\n\n" +
                   line + Environment.NewLine;
        }

        public static bool SaveLog(string log)
        {
            try
            {
                using (var writer = new StreamWriter("DashboardErrorLog.txt", true))
                {
                    writer.WriteLine(log);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Task ErrorLogGeneratorAsync(Exception ex, bool saveLog, bool sendLog)
        {
            return Task.Run(() => ErrorLogGenerator(ex, saveLog, sendLog));
        }



        public static void ErrorLogGenerator(Exception ex, bool saveLog, bool sendLog)
        {

            string log = ErrorLog(ex);

            if (saveLog)
            {
                SaveLog(log);
            }
            if (sendLog)
            {
                EmailLog(log, ex.Message);
            }

            App.Current.Properties["UserMessage"] = null;

        }

        public static void EmailLog(string log, string msg)
        {


            var subject = TruncateMsg(msg);

            MailMessage message = new MailMessage(ErrorMsgClient.Email, ErrorMsgClient.Email, subject, log);

            try
            {

                ErrorMsgClient.Client.Send(message);
                MessageBox.Show("Your error log has been sent.", "Log Processed",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch
            {
                MessageBox.Show("Unable to send message. \n\nA copy of the log file has been saved to the " +
                                "application's current directory", "Sending Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        public static string TruncateMsg(string str)
        {
            return str.Length < 55 ? str : str.Remove(15);
        }
    }
}

