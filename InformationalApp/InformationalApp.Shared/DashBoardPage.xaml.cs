﻿using InformationalApp.Classes;
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
    public sealed partial class DashBoardPage : Page
    {
        string name = string.Empty;
      
        public DashBoardPage()
        {
            this.InitializeComponent();
        }
       protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string val = e.Parameter as string;
            name = val;
                 //messageBox(val);
           base.OnNavigatedTo(e);
            /* string val = e.Parameter as string;
            model = new LoginView();

            //

            i = model.getCourseId(val);
            // string me = i.insitution;
            //int id = i.Id;
            string name = i.course;


            // messageBox(me + "");
            list = model.getPossibleCareer(name);
            // list = model.getCourses(2);
            foreach (var inst in list)
            {
                listView.Items.Add(inst.Name);

            }**/
          
            

        }
       private async void messageBox(string msg)
       {
           var msgDlg = new Windows.UI.Popups.MessageDialog(msg);
           await msgDlg.ShowAsync();
       }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(PossibleCareerPage),name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HowTheyWorkPage), name);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SubjectOfferedPage), name);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(SubjectsDonePage), name);
        }
    }
}
