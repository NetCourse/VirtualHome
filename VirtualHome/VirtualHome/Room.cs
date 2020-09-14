using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    class Room
    {
        public string Name { get; }
        public Rooms Type { get; }

        public Room(string name, Rooms type)
        {
            Type = type;
            Name = name;
        }


    }
}
