using InformationalApp.Classes;
using SQLite;
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
    public sealed partial class MainPage : Page
    {
        private InstitutionViewModel model = null;

        public MainPage()
        {
            this.InitializeComponent();
           // this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string idNo = txtIdNumber.Text;
            string name,surname,idNumber,contacts, address, email, password, province;
                name = txtName.Text;
                surname = txtSurname.Text;
                idNumber = txtIdNumber.Text;
                contacts = txtContacts.Text;
                address = txtAddress.Text;
                province = txtProvince.Text;
                email = txtEmail.Text;
                password = txtPassword.Text;



                if (name == "" && surname == "" && idNumber == "" && contacts == "" && address == "" && province == "" && email == "" && password == "")
                {
                    messageBox("make sure all field are filled with correct values");
                }
                else
                {
                    Enroll newUser = new Enroll()
                    {

                        name = txtName.Text,
                        surname = txtSurname.Text,
                        idNumber = txtIdNumber.Text,
                        contacts = txtContacts.Text,
                        address = txtAddress.Text,
                        province = txtProvince.Text,
                        email = txtEmail.Text,
                        password = txtPassword.Text
                    };
                    SQLiteAsyncConnection conn = new SQLiteAsyncConnection("Registers.db");
                    await conn.InsertAsync(newUser);
                    if (model.getUser(idNo) == null)
                    {
                        messageBox("You are not registered");
                    }
                    else
                    {
                        messageBox("You are successfully registered");
                    }
                }
            


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = new InstitutionViewModel();
            if (model.getInstitution() == null)
            {
                model.addInstitution("Tshwane University of Technology");
                model.addInstitution("University of Johannesburg");
                model.addInstitution("Jeppe College");
                model.addInstitution("University of Limpopo");
                model.addInstitution("Tshwane North College");
              
            }
            if (model.getCourse() == null)
            {
                model.addCourse("Information Technology",64);
                model.addCourse("Policing", 64);
                model.addCourse("mechanical Engineering", 64);
                model.addCourse("Analytical chemistry", 65);
                model.addCourse("mechanical Engineering", 65);
                model.addCourse("Phamaceutical", 65);
                model.addCourse("Local Government Management", 66);
                model.addCourse("Policing", 66);
                model.addCourse("Accounting", 66);
                model.addCourse("Computer Sciences", 67);
                model.addCourse("Education", 67);
                model.addCourse("Phamaceutical", 67);
                model.addCourse("Road and Traffic Management", 68);
                model.addCourse("Local Government Management", 68);
                model.addCourse("Information Technology", 68);
                
            }
            if (model.getCareer() == null)
            {
                model.addCareers("Software Developer \n Telecommunication \n Business Analyst", "Information Technology");
                model.addCareers("Hire Resolve \n Construct Executive Research \n Maintanance", "mechanical Engineering");
                model.addCareers("Detective Service \n Criminal Investigator", "Policing");
                model.addCareers("Pharmacist \n Surgeon \n Medical Representative - Pharmaceutical Industry ", "Phamaceutical");
                model.addCareers("Chartered Accountant \n Accounting technician\nBusiness Analyst", "Accounting");
                model.addCareers("Pharmacist \n Laboratory Technician \nLab Analyst", "Analytical chemistry");
                model.addCareers("Supply chain Management \n Finacial Management Support\nConsultant: Waste Management", "Local Government Management");
                model.addCareers("Software Developer \n Data Analyst \n Software Engineer ", "Computer Sciences");
                model.addCareers("Educator \n Lecturer \n Professor and Head of Department ", "Education");
                model.addCareers("Traffic Accommodation Officer \n Specialist: Risk Management \n Traffic Cop ", "Road and Traffic Management");
               
            }
            if (model.getSubjectsOffered() == null)
            {
                model.addSubjectsOffered("Information Technology", "visual basics", "DSO17AT", "R1500");
                model.addSubjectsOffered("Information Technology", "System software", "SSF30AT", "R1700");
            }
            if (model.getSubjectsDone()== null)
            {
                model.addSubjectsDone("Mathematics", "Information Technology");
            }
            if (model.getHowTheyWork() == null)
            {
                model.addHowTheyWork( "Information Technology","Assets/it.jpg");
                model.addHowTheyWork("Policing", "Assets/download.jpg");
            }
            base.OnNavigatedTo(e);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UpdateInformationPage)); 
        }
    }
}
