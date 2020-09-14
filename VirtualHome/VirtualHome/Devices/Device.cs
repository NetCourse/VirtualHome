using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    abstract class Device : IDevice
    {
        public string Name { get; }
        public Room Location;
        public bool TurnedOn;

        public Device(string name)
        {
            Name = name;
        }

        public Device(string name, Room location, bool turnedOn)
        {
            Name = name;
            Location = location;
            TurnedOn = turnedOn;
        }

        public void Assign(Room room)
        {
            Location = room;
            Console.WriteLine(this.GetType().ToString() + " " + this.Name + " has been assigned to room " + room);
        }

        public void TurnOffDevice()
        {
            TurnedOn = false;
            Console.WriteLine(this.GetType().ToString() + " " + this.Name + " has its lights turned OFF");

        }

        public void TurnOnDevice()
        {
            TurnedOn = true;
            Console.WriteLine(this.GetType().ToString() + " " + this.Name + " has its lights turned ON");
        }
    }
}
