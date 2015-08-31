using InformationalApp.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InformationalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private LoginView view;
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            view = new LoginView();
            string email = txtUsername.Text;
            string pass = txtPassword.Text;
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                if (view.getData(email, pass) != null)
                {
                    this.Frame.Navigate(typeof(InstitutionPage));
                }
                else
                {
                    messageBox("You have entered wrong password");
                }
            }
            else
            {
                messageBox("please enter values");

            }
        }
        
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void btnForgettenPassword_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(forgetPasswordPage));
        }

       
       
    }
}
