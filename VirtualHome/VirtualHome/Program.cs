using System;

namespace VirtualHome
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello Weird World!");
            var home = HouseBuilder.BuildHome();

            //DeviceManager.GenerateDevices();

            Devices.Light Nightlamp = new Devices.Light("Nightlamp");
            Devices.Light Desklamp = new Devices.Light("Desklamp");
            Devices.Oven Oven = new Devices.Oven("Oven");

            //Nightlamp.Assign(home[home.IndexOf("Bedroom")]);

        }
    }
}
