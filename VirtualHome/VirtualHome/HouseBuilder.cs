using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    class HouseBuilder
    {
        public static List<Room> BuildHome()
        {
            var home = new List<Room>();

            //home.Add(new Room("Kitchen", Rooms.Kitchen));
            //home.Add(new Room("Bedroom", Rooms.Bedroom));
            //home.Add(new Room("LivingRoom", Rooms.LivingRoom));
            //home.Add(new Room("Bathroom", Rooms.Bathroom));

            foreach(Rooms val in Enum.GetValues(typeof(Rooms)))
            {
                home.Add(new Room(val.ToString(), val));
            }

            Console.WriteLine("Home contains following rooms:");

            foreach (var element in home)
            {
                Console.WriteLine(element.Name);
            }

            return home;
        }
    }
}
