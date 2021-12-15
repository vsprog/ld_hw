using PowerStateManagement.Settings;
using System;
using System.Runtime.InteropServices;

namespace PowerStateManagement
{
    public class PowerStateManager
    {
        #region power info
        public DateTime GetLastSleepTime()
        {
            long mSecs = GetPowerData<long>(PowerInformationLevel.LastSleepTime);
            return new DateTime(mSecs);
        }
        
        public DateTime GetLastWakeTime()
        {
            long mSecs = GetPowerData<long>(PowerInformationLevel.LastWakeTime);
            return new DateTime(mSecs);
        }

        
        public SystemBatteryState GetSystemBatteryState()
        {
            var batteryState = GetPowerData<SystemBatteryState>(PowerInformationLevel.SystemBatteryState);
            return batteryState;
        }

        public SystemPowerInformation GetSystemPowerInformation()
        {
            var powerInfo = GetPowerData<SystemPowerInformation>(PowerInformationLevel.SystemPowerInformation);
            return powerInfo;
        }
        #endregion

        #region hibernate file operations
        public void ReserveHibernateFile()
        {
            HibernateFileAction(toDelete: false);
        }

        public void DeleteHibernateFile()
        {
            HibernateFileAction(toDelete: true);
        }
        #endregion

        #region suspend operations
        public void Hibernate()
        {
            PowerStateManagerInterop.SetSuspendState(true, true, true);
        }

        public void Standby()
        {
            PowerStateManagerInterop.SetSuspendState(false, true, true);
        }
        #endregion

        #region private
        private T GetPowerData<T>(PowerInformationLevel level)
        {
            int size = Marshal.SizeOf<T>();
            IntPtr lpOutputBuffer = Marshal.AllocCoTaskMem(size);
            uint status = PowerStateManagerInterop.CallNtPowerInformation((int)level, IntPtr.Zero, 0, lpOutputBuffer, (uint)size);

            if (status != PowerStateManagerInterop.STATUS_SUCCESS) throw new AggregateException();

            var result =  Marshal.PtrToStructure<T>(lpOutputBuffer);
            Marshal.FreeHGlobal(lpOutputBuffer);

            return result;
        }

        private void HibernateFileAction(bool toDelete = false)
        {
            int action = toDelete ? 0 : 1;
            int size = Marshal.SizeOf<bool>();
            IntPtr lpInputBuffer = Marshal.AllocCoTaskMem(size);
            Marshal.WriteByte(lpInputBuffer, (byte)action);
            uint status = PowerStateManagerInterop.CallNtPowerInformation((int)PowerInformationLevel.SystemReserveHiberFile, lpInputBuffer, (uint)size, IntPtr.Zero, 0);

            if (status != PowerStateManagerInterop.STATUS_SUCCESS) throw new AggregateException();

            Marshal.FreeHGlobal(lpInputBuffer);
        }
        #endregion
    }
}
