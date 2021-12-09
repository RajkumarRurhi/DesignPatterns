using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface IElectronicDevice
    {
        public void On();
        public void Off();
        public void VolumeUp();
        public void VolumeDown();
    }
}
