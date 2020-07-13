using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinLocation.Services
{
    interface ILocationService
    {
        Task<Location> GetCurrentLocation();
        Task<PermissionStatus> RequestLocationPermission();
        Task<PermissionStatus> CheckLocationPermission();
        Task<bool> IsLocationPermissionGranted();
    }
}
