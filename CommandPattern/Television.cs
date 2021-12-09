using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Television : IElectronicDevice
    {
        private int volume = 0;
        public void Off()
        {
            Console.WriteLine("TV is Off");
        }

        public void On()
        {
            Console.WriteLine("TV is On");
        }

        public void VolumeDown()
        {
            volume--;
            Console.WriteLine($"TV is voumen is down at {volume}");
        }

        public void VolumeUp()
        {
            volume++;
            Console.WriteLine($"TV is voumen is up at {volume}");
        }
    }
}
