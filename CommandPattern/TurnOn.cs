using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnOn : ICommand
    {
        private readonly IElectronicDevice electronicDevice;

        public TurnOn(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            electronicDevice.On();
        }

        public void Undo()
        {
            electronicDevice.Off();
        }
    }
}
