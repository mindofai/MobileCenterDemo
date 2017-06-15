using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileCenterDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MobileCenterDemo.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start("android=3aa2bc4d-4b2a-4a75-b86f-da174dc93b69;" +
            "uwp={Your UWP App secret here};" +
            "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
