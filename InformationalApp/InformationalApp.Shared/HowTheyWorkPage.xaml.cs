using InformationalApp.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace InformationalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HowTheyWorkPage : Page
    {
        LoginView model;
        ObservableCollection<HowTheyWorkViewModel> list;
        HowTheyWork i;
        public HowTheyWorkPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            i = new HowTheyWork();
            string val = e.Parameter as string;
            model = new LoginView();

            i = model.getWorkId(val); 

            string name = i.course;
         

            list = model.getHowTheyWork(name);
           // Image imageControl = new Image();

          
            //pic.Add(imageControl);


           
        
           // messageBox(val + pic.FindName("Assets/it.jpg"));
            foreach (var inst in list)
            {
                if (name.Equals("Information Technology"))
                {
                    pic.Source = new BitmapImage(new Uri(
                              "ms-appx:///Assets/it.jpg", UriKind.Absolute));
                }
                if (name.Equals("Policing"))
                {
                    pic.Source = new BitmapImage(new Uri(
                              "ms-appx:///Assets/download.jpg", UriKind.Absolute));
                }

            }

            base.OnNavigatedTo(e);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private async void messageBox(string msg)
        {
            var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
            await msgDlg.ShowAsync();
        }
     
    }
    
  
   
}
