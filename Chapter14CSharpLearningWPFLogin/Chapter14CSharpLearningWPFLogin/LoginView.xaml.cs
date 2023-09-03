using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter14CSharpLearningWPFLogin
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void OnLogingBtnClicked(object sender, RoutedEventArgs e)
        {
            string passwordEntered = PasswordBox.Password;

            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");
            if (envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("Entered correct password");
                }
                else
                {
                    MessageBox.Show("Entered wrong password");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }
        }
            private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }


    }
}
