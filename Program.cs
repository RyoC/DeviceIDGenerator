using System;
using System.Linq;
using DeviceId;

namespace DeviceIDGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceIdBuilder deviceId = new();

            if (args.Length == 1 && "-h".Equals(args[0]))
            {
                Console.WriteLine("-ma : MacAddress");
                Console.WriteLine("-mn : MachineName");
                Console.WriteLine("-ms : MotherboardSerialNumber");
                Console.WriteLine("-oi : OSInstallationID");
                Console.WriteLine("-ov : OSVersion");
                Console.WriteLine("-pi : ProcessorId");
                Console.WriteLine("-ss : SystemDriveSerialNumber");
                Console.WriteLine("-su : SystemUUID");
                Console.WriteLine("-un : UserName");
            }
            else 
            {
                if (args.Contains("-ma")) 
                {
                    deviceId.AddMacAddress(true, true);
                }

                if (args.Contains("-mn")) 
                {
                    deviceId.AddMachineName();
                }

                if (args.Contains("-ms"))
                {
                    deviceId.AddMotherboardSerialNumber();
                }

                if (args.Contains("-oi"))
                {
                    deviceId.AddOSInstallationID();
                }

                if (args.Contains("-ov"))
                {
                    deviceId.AddOSVersion();
                }

                if (args.Contains("-pi"))
                {
                    deviceId.AddProcessorId();
                }

                if (args.Contains("-ss"))
                {
                    deviceId.AddSystemDriveSerialNumber();
                }

                if (args.Contains("-su"))
                {
                    deviceId.AddSystemUUID();
                }

                if (args.Contains("-un"))
                {
                    deviceId.AddUserName();
                }

                Console.WriteLine($"{deviceId}");
            }
        }
    }
}
