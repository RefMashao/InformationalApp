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
    public sealed partial class UpdatePage : Page
    {
        InstitutionViewModel obj = new InstitutionViewModel();
        Enroll i;
        string id;
      string name, surname, contacts, address, province, idNumber;

        public UpdatePage()
        {
            this.InitializeComponent();
            
            //string id = txtIdNumber.Text;
             //var user = obj.getRegisteredUser(id);


            /* txtName.Text = user.name;
             txtSurname.Text = user.surname;
             txtIdNumber.Text = user.idNumber;
             txtContacts.Text = user.contacts;
             txtAddress.Text = user.address;
             txtProvince.Text = user.province;**/
            // messageBox(user + "");
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Enroll val = e.Parameter as Enroll;

            //var user = obj.getRegisteredUser(val);

        
            txtName.Text = val.name;
            txtSurname.Text = val.surname;
            txtIdNumber.Text = val.idNumber;
            txtContacts.Text = val.contacts;
            txtAddress.Text = val.address;
            txtProvince.Text = val.province;
           // messageBox(val.name);
            base.OnNavigatedTo(e);
        }


     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = obj.getRegisteredUser(id);


       
            name = txtName.Text;
            surname = txtSurname.Text;
            idNumber = txtIdNumber.Text;
            contacts = txtContacts.Text;
            address = txtAddress.Text;
            province = txtProvince.Text;

            //InstitutionViewModel obj = new InstitutionViewModel();
            if (name.Trim() != "" && surname.Trim() != "" && contacts.Trim() != "" && address.Trim() != "" && province.Trim() != "")
            {
                obj.updateDetails(name, surname, idNumber, contacts, address, province);
                messageBox("Your details has been updated");
            }
            else
            {

                messageBox("fill all the field with data");
            }
        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

    }
}
