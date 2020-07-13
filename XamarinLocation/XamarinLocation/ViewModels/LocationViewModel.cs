using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinLocation.Services;

namespace XamarinLocation.ViewModels
{
    class LocationViewModel : BaseViewModel
    {
        public ILocationService locationService => DependencyService.Get<ILocationService>();
        public IPlatformSpecificLocationService platFormLocationService => DependencyService.Get<IPlatformSpecificLocationService>();

        public LocationViewModel()
        {
            GetLocationCommand = new Command(async () => await GetLocation());
            OpenAppSettingsPageCommand = new Command(OpenAppSettingsPage);
            CheckLocationPermissionsCommand = new Command(async() => await CheckLocationPermissions());
            CheckDeviceLocationServiceCommand = new Command(CheckDeviceLocationService);
        }

        private void CheckDeviceLocationService()
        {
            var status = platFormLocationService.IsLocationServiceEnabled();
            DeviceLocationServiceStatus = status.ToString();
        }

        private async Task CheckLocationPermissions()
        {
            var status = await locationService.IsLocationPermissionGranted();
            LocationPermissionStatus = status.ToString();
        }

        private void OpenAppSettingsPage()
        {
            AppInfo.ShowSettingsUI();
        }

        private async Task GetLocation()
        {
            var location = await locationService.GetCurrentLocation();
            Latitude = location.Latitude;
        }

        private double latitude;
        public double Latitude
        {
            get { return latitude; }
            set 
            { 
                latitude = value;
                OnPropertyChanged();
            }
        }

        private double longitude;
        public double Longitude
        {
            get { return longitude; }
            set 
            { 
                longitude = value;
                OnPropertyChanged();
            }
        }

        private double accuracy;
        public double Accuracy
        {
            get { return accuracy; }
            set 
            { 
                accuracy = value;
                OnPropertyChanged();
            }
        }

        private string locationPermissionStatus;
        public string LocationPermissionStatus
        {
            get { return locationPermissionStatus; }
            set
            {
                locationPermissionStatus = value;
                OnPropertyChanged();
            }
        }

        private string deviceLocationServiceStatus;
        public string DeviceLocationServiceStatus
        {
            get { return deviceLocationServiceStatus; }
            set
            {
                deviceLocationServiceStatus = value;
                OnPropertyChanged();
            }
        }

        public Command GetLocationCommand { get; }
        public Command OpenAppSettingsPageCommand { get; }
        public Command CheckLocationPermissionsCommand { get; }
        public Command CheckDeviceLocationServiceCommand { get; }
    }
}
