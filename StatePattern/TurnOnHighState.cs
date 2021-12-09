using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class TurnOnHighState : State
    {
        private readonly Fan fan;

        public TurnOnHighState(Fan fan)
        {
            this.fan = fan;
        }

        public override void ExecuteRequest()
        {
            Console.WriteLine("Turning fan off.");
            fan.CurrentState = fan.OffState;
        }

        public override string ToString()
        {
            return "Fan is on high";
        }
    }
}
