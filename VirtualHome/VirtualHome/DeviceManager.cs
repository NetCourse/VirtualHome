using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    class DeviceManager
    {
        public static List<VirtualHome.Devices.Device> GenerateDevices()
        {
            var items = new List<VirtualHome.Devices.Device>();

            items.Add(new Devices.Light("Nightlamp"));
            items.Add(new Devices.Light("Desklamp"));
            items.Add(new Devices.Oven("Oven"));

            //Devices.Light Nightlamp = new Devices.Light("Nightlamp");
            //Devices.Light Desklamp = new Devices.Light("Desklamp");
            //Devices.Oven Oven = new Devices.Oven("Oven");
            Console.WriteLine("Following items have been generated:");

            foreach (var element in items)
            {
                Console.WriteLine(element.Name);
            }
            return items;
        }
        public static List<Devices.Device> GenerateBedroomLamps(List<Room> bedrooms)
        {
            List<Devices.Device> BedroomLamps = new List<Devices.Device>();

            foreach (var bedroom in bedrooms)
            {
                BedroomLamps.Add(new Devices.Light(bedroom.Name + "Nightlamp"));
            }

            return BedroomLamps;
        }
    }
}
