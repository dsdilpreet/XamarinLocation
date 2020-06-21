using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinLocation.Services;

namespace XamarinLocation.ViewModels
{
    class LocationViewModel : BaseViewModel
    {
        public ILocationService locationService => DependencyService.Get<ILocationService>();

        public LocationViewModel()
        {
            GetLocationCommand = new Command(async () => await GetLocation());
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

        public Command GetLocationCommand { get; }
    }
}
