using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    internal class TurnOffAllLights : ICommand
    {
        private readonly Mediator mediator;

        public TurnOffAllLights(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public void Execute()
        {
            mediator.TurnOffAllLights();
        }
    }
}
