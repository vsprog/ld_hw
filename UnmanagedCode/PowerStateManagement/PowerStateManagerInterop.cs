using System;
using System.Runtime.InteropServices;

namespace PowerStateManagement
{
    internal class PowerStateManagerInterop
    {
        internal const uint STATUS_SUCCESS = 0;

        [DllImport("powrprof.dll", SetLastError = true)]
        public static extern UInt32 CallNtPowerInformation(
            Int32 InformationLevel,
            IntPtr lpInputBuffer,
            UInt32 nInputBufferSize,
            IntPtr lpOutputBuffer,
            UInt32 nOutputBufferSize);

        [DllImport("powrprof.dll", SetLastError = true)]
        public static extern bool SetSuspendState(
            bool Hibernate,
            bool ForceCritical,
            bool DisableWakeEvent
        );
    }
}
