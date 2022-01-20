using System;
using System.Runtime.InteropServices;

namespace Task1.PasswordHashGenerator
{
    internal class Bpkdf2Interop
    {
        /// <summary>
        /// Derive a key using PBKDF2
        /// </summary>
        /// <param name="hAlgorithm">Algorithm opened using <see cref="BCryptOpenAlgorithmProvider"/></param>
        /// <param name="pbPassword">Private piece of key material</param>
        /// <param name="cbPassword">Byte length of <paramref name="pbPassword"/></param>
        /// <param name="pbSalt">Public piece of key material</param>
        /// <param name="cbSalt">Byte length of <paramref name="pbSalt"/></param>
        /// <param name="cIterations">Number of iterations</param>
        /// <param name="pbDerivedKey">Memory to hold derived bytes</param>
        /// <param name="cbDerivedKey">Length of <paramref name="pbDerivedKey"/></param>
        /// <param name="dwFlags">Reserved. Must be <see cref="BCryptFlags.NO_FLAGS"/></param>
        /// <returns>NT status</returns>
        /// <seealso cref="https://docs.microsoft.com/en-us/windows/win32/api/bcrypt/nf-bcrypt-bcryptderivekeypbkdf2"/>
        [DllImport("Bcrypt.dll")]
        public static extern int BCryptDeriveKeyPBKDF2(
            IntPtr hAlgorithm,
            byte[] pbPassword,
            int cbPassword,
            byte[] pbSalt,
            int cbSalt,
            long cIterations,
            [Out] byte[] pbDerivedKey,
            int cbDerivedKey,
            BCryptFlags dwFlags);

        /// <summary>
        /// Opens a BCrypt algorithm
        /// </summary>
        /// <param name="phAlgorithm">Pointer to algorithm</param>
        /// <param name="pszAlgId">Algorithm name</param>
        /// <param name="pszImplementation">Implementation name. <see cref="null"/> for default</param>
        /// <param name="dwFlags">Algorithm flags</param>
        /// <returns>NT status</returns>
        /// <seealso cref="https://docs.microsoft.com/en-us/windows/win32/api/bcrypt/nf-bcrypt-bcryptopenalgorithmprovider"/>
        [DllImport("Bcrypt.dll")]
        public static extern int BCryptOpenAlgorithmProvider(
            out IntPtr phAlgorithm,
            [MarshalAs(UnmanagedType.LPWStr)]
            string pszAlgId,
            [MarshalAs(UnmanagedType.LPWStr)]
            string pszImplementation,
            BCryptFlags dwFlags);

        /// <summary>
        /// Closes algorithm that was opened with <see cref="BCryptOpenAlgorithmProvider(out IntPtr, string, string, BCryptFlags)"/>
        /// </summary>
        /// <param name="phAlgorithm">Algorithm handle</param>
        /// <param name="dwFlags">Must be <see cref="BCryptFlags.NO_FLAGS"/></param>
        /// <returns>NT status</returns>
        /// <seealso cref="https://docs.microsoft.com/en-us/windows/win32/api/bcrypt/nf-bcrypt-bcryptclosealgorithmprovider"/>
        [DllImport("Bcrypt.dll")]
        public static extern int BCryptCloseAlgorithmProvider(
            IntPtr phAlgorithm,
            BCryptFlags dwFlags);
    }
}
