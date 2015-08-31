using InformationalApp.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class SubjectOfferedPage : Page
    {
        LoginView model;
        ObservableCollection<SubjectOfferedViewModel> list;
        SubjectsOffered i;
        public SubjectOfferedPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string val = e.Parameter as string;
            model = new LoginView();

            

            i = model.getSubOfferId(val);
            // string me = i.insitution;
            //int id = i.Id;
            string name = i.course;
            //string subname = i.subjectName ;
            //string code = i.code;
            //double price = i.price;


            // messageBox(me + "");
            list = model.getSubjectsOffered(name);
            // list = model.getCourses(2);
            foreach (var inst in list)
            {
                listView.Items.Add(inst.SubjectName + " " + inst.Code + " " + inst.Price );

            }
            
            //messageBox(val);
            base.OnNavigatedTo(e);

        }
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
