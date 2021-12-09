using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class TurnOnLowState : State
    {
        private readonly Fan fan;

        public TurnOnLowState(Fan fan)
        {
            this.fan = fan;
        }

        public override void ExecuteRequest()
        {
            Console.WriteLine("Turning fan medium.");
            fan.CurrentState = fan.OnMediumState;
        }

        public override string ToString()
        {
            return "Fan is on low";
        }
    }
}
