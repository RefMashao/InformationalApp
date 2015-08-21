﻿using InformationalApp.Classes;
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
        public MainPage()
        {
            this.InitializeComponent();
           // this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
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
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LoginPage));
        }

        
    }
}
