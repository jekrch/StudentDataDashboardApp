using System.Net;
using System.Net.Mail;

namespace PFdata.Dashboard.Data
{
    public class ErrorMsgClient
    {
        public static string Email = "dashboarderrormessages@gmail.com";
        public static SmtpClient Client = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            UseDefaultCredentials = false,
            
            // Credentials redacted for public repository
            Credentials = new NetworkCredential("redacted", "redacted")
        };
    }
}
