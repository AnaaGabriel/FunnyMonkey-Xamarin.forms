using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FunnyMonkey_Xamarin.forms.Views;

using Xamarin.Forms;

namespace FunnyMonkey_Xamarin.forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pictures();
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
