using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Task1.PasswordHashGenerator
{
    class Program
    {
        private static readonly byte[] salt = new byte[] { 101, 78, 240, 67, 54, 187, 126, 9, 98, 164, 233, 145, 32, 228, 199, 15 };
        private static readonly string passwordText = "qwerty123ASDF";
        private static readonly int iterate = 10000;

        static void Main(string[] args)
        {
            Console.WriteLine($"password: {passwordText}\n");
            ShowStat(GeneratePasswordHashUsingSalt, nameof(GeneratePasswordHashUsingSalt));
            ShowStat(FastGeneratePasswordHashUsingSalt, nameof(FastGeneratePasswordHashUsingSalt));
            
            Console.ReadLine();
        }

        private static string GeneratePasswordHashUsingSalt()
        {
            var pbkdf2 = new Rfc2898DeriveBytes(passwordText, salt, iterate);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            var passwordHash = Convert.ToBase64String(hashBytes);

            return passwordHash;
        }

        private static string FastGeneratePasswordHashUsingSalt()
        {
            var pbkdf2 = new Bpkdf2(passwordText, salt, iterate);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            var passwordHash = Convert.ToBase64String(hashBytes);

            return passwordHash;
        }

        private static void ShowStat(Func<string> gereratePasswordHash, string methodName)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string hash = gereratePasswordHash();
            sw.Stop();

            Console.WriteLine($"{methodName} time: {sw.ElapsedMilliseconds}ms");
            Console.WriteLine($"hash: {hash}\n");
        }
    }
}
