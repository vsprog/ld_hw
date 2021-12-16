using System;
using System.Runtime.InteropServices;

namespace PowerStateManagement.Settings
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemBatteryState
    {
        public Int32 AcOnLine;
        public Int32 BatteryPresent;
        public Int32 Charging;
        public Int32 Discharging;
        public Int32 Spare1;
        public Int32 Spare2;
        public Int32 Spare3;
        public Int32 Spare4;
        public uint MaxCapacity;
        public uint RemainingCapacity;
        public uint Rate;
        public uint EstimatedTime;
        public uint DefaultAlert1;
        public uint DefaultAlert2;
    }
}
