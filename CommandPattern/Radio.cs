using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Radio : IElectronicDevice
    {
        private int volume = 0;
        public void Off()
        {
            Console.WriteLine("Radio is Off");
        }

        public void On()
        {
            Console.WriteLine("Radio is On");
        }

        public void VolumeDown()
        {
            volume--;
            Console.WriteLine($"Radio volume is down to {volume}");
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine($"Radio volume is up to {volume}");
        }
    }
}
