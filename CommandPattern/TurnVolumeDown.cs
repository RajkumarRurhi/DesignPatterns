using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnVolumeDown : ICommand
    {
        private readonly IElectronicDevice electronicDevice;

        public TurnVolumeDown(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            electronicDevice.VolumeDown();
        }

        public void Undo()
        {
            electronicDevice.VolumeUp();
        }
    }
}
