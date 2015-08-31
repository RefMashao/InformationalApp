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
    public sealed partial class forgetPasswordPage : Page
    {
        public forgetPasswordPage()
        {
            this.InitializeComponent();
        }

        private void btnPassword_Click(object sender, RoutedEventArgs e)
        {
            string id = txtIDnumber.Text;
            string password, username;
            var obj = new InstitutionViewModel();

            var user = obj.getUser(id);
            if(user != null)
            {
                username = user.email;
                password = user.password;

                messageBox("password is " + password + "username is " + username);
            }else
            {
                messageBox("The user does not exist please make sure you enter a valid ID");
            }


        }

        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InstitutionViewModel obj = new InstitutionViewModel();

            string id = txtIdNumber.Text;
            string pass = txtPassword.Text;
            string conpass = txtConfirmPassword.Text;

            var user = obj.getRegisteredUserLogin(id);
            if(user != null)
            {
            if ( pass != "" && conpass != "")
            {
                if (pass == conpass)
                {
                    obj.updateLogin(id,pass,conpass);
                    messageBox("Your password is been reset");
                        this.Frame.Navigate(typeof(LoginPage));
                }
                else
                {
                    messageBox("Your password must match");
                }
            }
            else {
                messageBox("Enter the correct information");
                }
            }
        }

      
       

    }
}
