using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    internal class TurnOnAllLights : ICommand
    {
        private readonly Mediator mediator;

        public TurnOnAllLights(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public void Execute()
        {
            mediator.TurnOnAllLights();
        }
    }
}
