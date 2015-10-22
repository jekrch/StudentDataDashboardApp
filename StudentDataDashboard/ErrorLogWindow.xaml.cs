using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using PFdata.Dashboard.Data;
using PFdata.Properties;

namespace PFdata
{
    /// <summary>
    /// Interaction logic for ErrorLogWindow.xaml
    /// </summary>
    public partial class ErrorLogWindow : Window
    {
        private MenuItem logMenuItem;
        public ErrorLogWindow()
        {
            InitializeComponent();
            SystemSounds.Exclamation.Play();

            cbxDisplayPrompt.IsChecked = Settings.Default.DisplayErrorPrompt;

            cbxSaveLog.IsChecked = Settings.Default.SaveLog;
            cbxSendLog.IsChecked = Settings.Default.SendLog;

            logMenuItem = (MenuItem)App.Current.Properties["LogSettingsMenuItem"];

            var curApp = Application.Current;
            var mainWindow = curApp.MainWindow;

            this.Left = mainWindow.Left + 325;
            this.Top = mainWindow.Top + 100;
           
        }

        private async void YesBtn_Click(object sender, RoutedEventArgs e)
        {
            Exception ex = (Exception)App.Current.Properties["LoadException"];

            cbxDisplayPrompt.IsChecked = Settings.Default.DisplayErrorPrompt;

            var saveLog = cbxSaveLog.IsChecked != null && (bool)cbxSaveLog.IsChecked;
            var sendLog = cbxSendLog.IsChecked != null && (bool)cbxSendLog.IsChecked;

            LogProgress.IsIndeterminate = true;
            await ErrorLogger.ErrorLogGeneratorAsync(ex, saveLog, sendLog);
            LogProgress.IsIndeterminate = false;
            
            Close();
        }

        private void NoBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cbxDisplayPrompt_Click(object sender, RoutedEventArgs e)
        {
            if (cbxDisplayPrompt.IsChecked != null)
            {
                Settings.Default.DisplayErrorPrompt = (bool)cbxDisplayPrompt.IsChecked;

                logMenuItem.IsChecked = Settings.Default.DisplayErrorPrompt;
            }
        }

        private void cbxSaveLog_Click(object sender, RoutedEventArgs e)
        {
            if (cbxSaveLog.IsChecked != null) Settings.Default.SaveLog = (bool)cbxSaveLog.IsChecked;
            Settings.Default.Save();
        }

        private void cbxSendLog_Click(object sender, RoutedEventArgs e)
        {
            if (cbxSendLog.IsChecked != null) Settings.Default.SendLog = (bool)cbxSendLog.IsChecked;
            Settings.Default.Save();
        }

        private void MsgBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var userMessageWin = UserMessage.GetMsgWindow;

            if (userMessageWin != null)
            {
                userMessageWin.Show();
            }
            
        }
    }
}
