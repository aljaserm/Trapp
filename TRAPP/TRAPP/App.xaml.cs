﻿using Microsoft.WindowsAzure.MobileServices;
using System;
using TRAPP.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TRAPP
{
    public partial class App : Application
    {
        public static string DBLocation = string.Empty;
        public static MobileServiceClient MobileService =
            new MobileServiceClient(
            "https://trapp.azurewebsites.net"
        );
        public static User userGlobal = new User();

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        public App(string dbLocation)
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            DBLocation = dbLocation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
