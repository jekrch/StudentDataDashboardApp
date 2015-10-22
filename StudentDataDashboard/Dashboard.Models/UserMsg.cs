namespace PFdata.Dashboard.Models
{
    // Used to report file loading errors via email
    public class UserMsg
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MessageText { get; set; }
    }
}
