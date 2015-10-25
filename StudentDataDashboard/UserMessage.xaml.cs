using System.Linq;
using System.Windows;
using PFdata.Dashboard.Models;

namespace PFdata
{
    /// <summary>
    /// Interaction logic for UserMessage.xaml
    /// </summary>
    public partial class UserMessage : Window
    {
        private static UserMessage _window; 

        // Ensure that only one UserMessage window is open at a time
        public static UserMessage GetMsgWindow
        {
            get
            {
                if (Application.Current.Windows.OfType<UserMessage>().Any())
                {
                    return null;
                }

                _window = new UserMessage();

                return _window;
            }
        }

        public UserMessage()
        {
            InitializeComponent();
            if (Application.Current.Properties["UserMessage"] != null)
            {
                var savedMessage = (UserMsg) App.Current.Properties["UserMessage"];
                NameBox.Text = savedMessage.Name;
                EmailBox.Text = savedMessage.Email;
                MsgBox.Text = savedMessage.MessageText;
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var userMsg = new UserMsg()
            {
                Name = NameBox.Text,
                Email = EmailBox.Text,
                MessageText = MsgBox.Text,
            };

            App.Current.Properties["UserMessage"] = userMsg;

            Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close(); 
        }
    }
}
