using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    internal class TurnOffState : State
    {
        private readonly Fan fan;

        public TurnOffState(Fan fan)
        {
            this.fan = fan;
        }

        public override void ExecuteRequest()
        {
            Console.WriteLine("Turning fan on.");
            fan.CurrentState = fan.OnLowState;
        }

        public override string ToString()
        {
            return "Fan is off";
        }
    }
}
