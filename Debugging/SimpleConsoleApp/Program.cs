using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace SimpleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();

            if (networkInterface == null)
            {
                Console.WriteLine("Should be at least one network interface");
            }

            byte[] addressBytes = networkInterface.GetPhysicalAddress().GetAddressBytes();
            byte[] dateBytes = BitConverter.GetBytes(DateTime.Today.ToBinary());
            int[] source = addressBytes
                .Select((addByte, ind) => addByte ^ dateBytes[ind])
                .Select(x => x <= 999 ? x * 10 : x)
                .ToArray();

            string key = string.Join("-", source);
            Console.WriteLine(key);
        }
    }
}
