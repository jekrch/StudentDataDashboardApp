using System.Net;
using System.Net.Mail;

namespace PFdata.Dashboard.Data
{
    // The client used for sending error messages
    public class ErrorMsgClient
    {
        public static string Email = "dashboarderrormessages@gmail.com";
        public static SmtpClient Client = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            UseDefaultCredentials = false,
            
            // Specific credentials are redacted for public repo
            Credentials = new NetworkCredential("redacted", "redacted")
        };
    }
}
