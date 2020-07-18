using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinLocation.Services;

[assembly: Dependency(typeof(XamarinLocation.Droid.LocationService))]
namespace XamarinLocation.Droid
{
    class LocationService : IPlatformSpecificLocationService
    {
        public bool IsLocationServiceEnabled()
        {
            LocationManager locationManager = (LocationManager)Android.App.Application.Context.GetSystemService(Context.LocationService);

            try
            {
                return locationManager.IsProviderEnabled(LocationManager.GpsProvider);
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool OpenDeviceLocationSettingsPage()
        {
            var intent = new Intent(Android.Provider.Settings.ActionLocationSourceSettings);
            intent.AddFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
            return true;
        }
    }
}