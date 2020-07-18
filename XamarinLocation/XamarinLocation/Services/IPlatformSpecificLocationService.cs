using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLocation.Services
{
    public interface IPlatformSpecificLocationService
    {
        bool IsLocationServiceEnabled();
        bool OpenDeviceLocationSettingsPage();
    }
}
