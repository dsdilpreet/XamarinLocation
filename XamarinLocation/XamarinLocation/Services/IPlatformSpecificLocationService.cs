using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinLocation.Services
{
    interface IPlatformSpecificLocationService
    {
        bool IsLocationServiceEnabled();
    }
}
