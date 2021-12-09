using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class TurnOnMediumState : State
    {
        private readonly Fan fan;

        public TurnOnMediumState(Fan fan)
        {
            this.fan = fan;
        }

        public override void ExecuteRequest()
        {
            Console.WriteLine("Turning fan high.");
            fan.CurrentState = fan.OnHighState;
        }

        public override string ToString()
        {
            return "Fan is on medium";
        }
    }
}
