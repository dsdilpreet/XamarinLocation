using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinLocation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About Xamarin Location";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/dsdilpreet"));
        }

        public ICommand OpenWebCommand { get; }
    }
}