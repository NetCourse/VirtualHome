using System;
using System.Collections.Generic;
using System.Linq;

namespace VirtualHome
{
    class Program
    {


        static void Main(string[] args)
        {
            var Home = HouseBuilder.BuildHome();
            var Items = DeviceManager.GenerateDevices();

            var Bedrooms = HouseBuilder.GetBedrooms(Home);
            var BedroomLamps = DeviceManager.GenerateBedroomLamps(Bedrooms);

            Console.WriteLine("Here are the Bedroom Lamps:");
            foreach (var Lamp in BedroomLamps)
            {
                Console.WriteLine(Lamp.Name);
            }
            



        }
    }
}
