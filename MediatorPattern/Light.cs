using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    internal class Light
    {
        private readonly string location;

        public Light(string location)
        {
            this.location = location;
        }

        public bool IsOn { get; set; } = false;

        public void Toggle()
        {
            if (IsOn)
            {
                Off();
            }
            else
            {
                On();
            }
        }
        public void On()
        {
            IsOn = true;
            Console.WriteLine($"{location} light switched on.");
        }

        public void Off()
        {
            IsOn = false;
            Console.WriteLine($"{location} light switched off.");
        }
    }
}
