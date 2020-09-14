using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualHome
{
    interface IDevice
    {
        public void Assign(Room room);

        public void TurnOnDevice();

        public void TurnOffDevice();
    }
}
