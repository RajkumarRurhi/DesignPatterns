using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class DeviceButton
    {
        private readonly ICommand command;

        public DeviceButton(ICommand command)
        {
            this.command = command;
        }

        public void Press()
        {
            command.Execute();
        }

        public void PressUndo()
        {
            command.Undo();
        }
    }
}
