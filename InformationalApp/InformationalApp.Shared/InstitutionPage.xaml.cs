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
using System.Resources;
using System.Collections;
using System.Windows.Input;
using SQLite;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InformationalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InstitutionPage : Page
    {
        LoginView model;
        ObservableCollection<InstitutionViewModel> list;
        InstitutionViewModel view = new InstitutionViewModel();
        private string item;
        private List<Institution> _myDataSource = new List<Institution>();
     
       // private string institution;
        
        
        public InstitutionPage()
        {
            this.InitializeComponent();
            
    
        }
      
     
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model = new LoginView();
            list = model.getAllInstitution();
            foreach (var inst in list)
            { 
                listView.Items.Add(inst.Name);
            }
            
            base.OnNavigatedTo(e);
        }

      
        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void listView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        { 
            var sel = listView.SelectedItems.ToArray();

            if (sel != null)
            {
                foreach (var a in sel)
                {
                    item = a.ToString();
                }
            }
            messageBox("You selected "+item);
            this.Frame.Navigate(typeof(CoursePage),item);

        }
       

        private async void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             SQLiteAsyncConnection conn = new SQLiteAsyncConnection("Registers.db");
            string name = txtSearch.Text;
           lstDisplay.Items.Clear();

            name = name + "%";
           var obj = await conn.QueryAsync<Institution>("select * from Institution where insitution like '" + name + "'");

           foreach (var a in obj)
           {
               lstDisplay.Items.Add(a.insitution);
           }
   
        }

        private void lstDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel = lstDisplay.SelectedItems.ToArray();

            if (sel != null)
            {
                foreach (var a in sel)
                {
                    item = a.ToString();
                }
            }
            //messageBox("You selected " + item);
            this.Frame.Navigate(typeof(CoursePage), item);

        }

    }
  
   
}
