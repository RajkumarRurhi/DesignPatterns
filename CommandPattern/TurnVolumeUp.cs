using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnVolumeUp : ICommand
    {
        private readonly IElectronicDevice electronicDevice;

        public TurnVolumeUp(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            electronicDevice.VolumeUp();
        }

        public void Undo()
        {
            electronicDevice.VolumeDown();
        }
    }
}
