using PowerStateManagement.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;

namespace PowerStateManagement
{
    public class PowerStateManager
    {
        public DateTime GetLastSleepTime()
        {
            long nSecs = GetPowerData<long>(PowerInformationLevel.LastSleepTime);
            DateTime lastSleepTime = GetLastBootUpTime().AddTicks(nSecs);

            return lastSleepTime;
        }
        
        public DateTime GetLastWakeTime()
        {
            long nSecs = GetPowerData<long>(PowerInformationLevel.LastWakeTime);
            DateTime lastWakeTime = GetLastBootUpTime().AddTicks(nSecs);

            return lastWakeTime;
        }

        /*
        public SystemBatteryState GetSystemBatteryState()
        {

        }

        public SystemPowerInformation GetSystemPowerInformation()
        {

        }*/

        private T GetPowerData<T>(PowerInformationLevel level)
        {
            int size = Marshal.SizeOf<T>();
            IntPtr lpOutputBuffer = Marshal.AllocCoTaskMem(size);
            uint status = PowerStateManagerInterop.CallNtPowerInformation((int)level, IntPtr.Zero, 0, lpOutputBuffer, (uint)size);

            if (status != PowerStateManagerInterop.STATUS_SUCCESS) throw new Win32Exception();

            var result =  Marshal.PtrToStructure<T>(lpOutputBuffer);
            Marshal.FreeHGlobal(lpOutputBuffer);

            return result;
        }

        private DateTime GetLastBootUpTime()
        {
            PropertyData lastBootUpTimeProperty = new ManagementClass("Win32_OperatingSystem")
                .GetInstances()
                .Cast<ManagementBaseObject>()
                .SelectMany(o => o.Properties.Cast<PropertyData>())
                .First(o => o.Name == "LastBootUpTime");
            var bootTime = ManagementDateTimeConverter.ToDateTime(lastBootUpTimeProperty.Value.ToString());

            return bootTime;
        }
    }
}
