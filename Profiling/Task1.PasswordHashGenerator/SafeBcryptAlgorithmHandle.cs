using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;

namespace Task1.PasswordHashGenerator
{
    public class SafeBcryptAlgorithmHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeBcryptAlgorithmHandle(IntPtr Handle) : base(true)
        {
            SetHandle(Handle);
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            Bpkdf2Interop.BCryptCloseAlgorithmProvider(handle, BCryptFlags.NO_FLAGS);
            SetHandleAsInvalid();
            return true;
        }
    }
}
