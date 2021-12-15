using PowerStateManagement.Settings;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace PowerStateManagement
{
    [ComVisible(true)]
    [Guid("D3EDDA38-51EA-4B28-93ED-51BB7589DB8B")]
    [ClassInterface(ClassInterfaceType.None)]
    public class PowerStateManager : IPowerStateManager
    {
        #region power info
        public string GetLastSleepTime()
        {
            long mSecs = GetPowerData<long>(PowerInformationLevel.LastSleepTime);
            return mSecs.ToString();
        }
        
        public string GetLastWakeTime()
        {
            long mSecs = GetPowerData<long>(PowerInformationLevel.LastWakeTime);
            return mSecs.ToString();
        }
                
        public string GetSystemBatteryState()
        {
            var batteryState = GetPowerData<SystemBatteryState>(PowerInformationLevel.SystemBatteryState);
            return StructToString(batteryState);
        }

        public string GetSystemPowerInformation()
        {
            var powerInfo = GetPowerData<SystemPowerInformation>(PowerInformationLevel.SystemPowerInformation);
            return StructToString(powerInfo);
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

        private string StructToString<T>(T structure)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                sb.Append($"{field.Name} = {field.GetValue(structure)}\n");
            }
            return sb.ToString();
        }
        #endregion
    }
}
