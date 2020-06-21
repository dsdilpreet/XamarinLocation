using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLocation.Services;
using XamarinLocation.Views;

namespace XamarinLocation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<LocationService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
