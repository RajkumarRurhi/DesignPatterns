using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnOff : ICommand
    {
        private readonly IElectronicDevice electronicDevice;

        public TurnOff(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            electronicDevice.Off();
        }

        public void Undo()
        {
            electronicDevice.On();
        }
    }
}
