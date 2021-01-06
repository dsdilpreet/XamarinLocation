using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreLocation;
using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinLocation.Services;

[assembly: Dependency(typeof(XamarinLocation.iOS.LocationService))]
namespace XamarinLocation.iOS
{
    class LocationService : IPlatformSpecificLocationService
    {
        public bool IsLocationServiceEnabled()
        {
            return CLLocationManager.LocationServicesEnabled;
        }

        public bool OpenDeviceLocationSettingsPage()
        {
            // this is not possible in iOS
            throw new NotImplementedException();
        }
    }
}