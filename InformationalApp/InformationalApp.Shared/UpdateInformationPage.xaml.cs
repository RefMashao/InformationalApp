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
   
    
  
    public sealed partial class UpdateInformationPage : Page
    {
        public UpdateInformationPage()
        {
            this.InitializeComponent();
            //string userID ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InstitutionViewModel obj = new InstitutionViewModel();
            string id = txtIdNumber.Text;
            var user = obj.getRegisteredUser(id);

            if (user == null)
            {
                messageBox("Enter the correct ID Number");
            }
            else {  
            this.Frame.Navigate(typeof(UpdatePage),obj.getRegisteredUser(id)); 
            }
          
        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }
    }

}
