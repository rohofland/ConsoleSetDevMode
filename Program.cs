using System;
using Microsoft.Win32;
//using System.Threading;

namespace EnableDeveloperMode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Define the registry key path
                string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock";

                // Open the registry key for write access
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyPath))
                {
                    if (key != null)
                    {
                        // Set the values to enable Developer Mode
                        Console.WriteLine("Setting developer mode, must be administrator!!!");
                        key.SetValue("AllowDevelopmentWithoutDevLicense", 1, RegistryValueKind.DWord);
                        //key.SetValue("AllowAllTrustedApps", 0, RegistryValueKind.DWord);

                        Console.WriteLine("Developer Mode enabled successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to open registry key.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

            // Pause the console to view the result
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            Console.WriteLine("Gedaan");
            Thread.Sleep(3000);
        }
    }
}
