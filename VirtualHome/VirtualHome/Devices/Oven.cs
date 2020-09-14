using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome.Devices
{
    class Oven : Device
    {
        public int Temperature;

        public Oven(string name) : base(name)
        {
        }

        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
            Console.WriteLine(this.GetType().ToString() + " " + this.Name + " has temperature set to " + Temperature);
        }
    }
}
