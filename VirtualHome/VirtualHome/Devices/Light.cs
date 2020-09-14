using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class Light : Device
    {
        public string Color;

        public Light(string name) : base(name)
        {
        }
        public void SetColor(string color)
        {
            Color = color;
            Console.WriteLine(this.GetType().ToString() + " " + this.Name + " has color set to " + color);
        }
    }
}
