using PowerStateManagement.Settings;
using System;
using System.Runtime.InteropServices;

namespace PowerStateManagement
{
    [ComVisible(true)]
    [Guid("BA0A88F8-050F-4C17-A06E-25DA3C23E376")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IPowerStateManager
    {
        string GetLastSleepTime();
        string GetLastWakeTime();
        string GetSystemBatteryState();
        string GetSystemPowerInformation();
        void ReserveHibernateFile();
        void DeleteHibernateFile();
        void Hibernate();
        void Standby();
    }
}
