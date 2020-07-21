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
            // not possible anymore according, one example
            // https://stackoverflow.com/questions/52301580/how-to-programmatically-open-settings-privacy-location-services-in-ios-11
            throw new NotImplementedException();
        }
    }
}