using System;
using System.ComponentModel;
using System.Text;

namespace Task1.PasswordHashGenerator
{
    public class Bpkdf2
    {
        private readonly byte[] salt;
        private readonly byte[] passwordBytes;
        private readonly int iterate;

        public Bpkdf2(string passwordText, byte[] salt, int iterate)
        {
            this.salt = salt;
            this.passwordBytes = Encoding.UTF8.GetBytes(passwordText);
            this.iterate = iterate;
        }

        public byte[] GetBytes(int count)
        {
            int status = Bpkdf2Interop.BCryptOpenAlgorithmProvider(
                out IntPtr Alg, 
                "SHA1", 
                null, 
                BCryptFlags.BCRYPT_ALG_HANDLE_HMAC_FLAG);

            using (var handle = new SafeBcryptAlgorithmHandle(Alg))
            {
                if (Alg != IntPtr.Zero)
                {
                    byte[] Result = new byte[count];

                    status = Bpkdf2Interop.BCryptDeriveKeyPBKDF2(
                        Alg,
                        passwordBytes,
                        passwordBytes.Length,
                        salt,
                        salt.Length,
                        iterate,
                        Result, 
                        Result.Length,
                        BCryptFlags.NO_FLAGS);

                    if (status != 0) throw new Win32Exception($"Key generator failed with NT Status {status}");

                    return Result;
                }
                else throw new Win32Exception($"Open failed with NT Status {status}");
            }
        }
    }
}
