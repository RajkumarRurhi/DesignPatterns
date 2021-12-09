using System;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice tv = TVRemote.GetDevice();

            TurnOn tvOnCommand = new TurnOn(tv);
            DeviceButton tvOnButton = new DeviceButton(tvOnCommand);
            tvOnButton.Press();
            tvOnButton.PressUndo();

            TurnOff tvOffCommand = new TurnOff(tv);
            DeviceButton tvOffButton = new DeviceButton(tvOffCommand);
            tvOffButton.Press();
            tvOffButton.PressUndo();

            TurnVolumeUp tvVolumeUpCommand = new TurnVolumeUp(tv);
            DeviceButton tvVolumeUpButton = new DeviceButton(tvVolumeUpCommand);
            tvVolumeUpButton.Press();
            tvVolumeUpButton.Press();
            tvVolumeUpButton.Press();
            tvVolumeUpButton.Press();
            tvVolumeUpButton.Press();
            tvVolumeUpButton.PressUndo();
            tvVolumeUpButton.PressUndo();

            TurnVolumeDown tvVolumeDownCommand = new TurnVolumeDown(tv);
            DeviceButton tvVolumeDownButton = new DeviceButton(tvVolumeDownCommand);
            tvVolumeDownButton.Press();
            tvVolumeDownButton.Press();
            tvVolumeDownButton.Press();
            tvVolumeDownButton.PressUndo();
            tvVolumeDownButton.PressUndo();

            tvOffButton.Press();

            IElectronicDevice radio = new Radio();

            TurnOn radioOnCommand = new TurnOn(radio);
            DeviceButton radioOnButton = new DeviceButton(radioOnCommand);
            radioOnButton.Press();

            TurnOff radioOffCommand = new TurnOff(radio);
            DeviceButton radioOffButton = new DeviceButton(radioOffCommand);
            radioOffButton.Press();

            radioOnButton.Press();

            TurnVolumeUp radioVolUpcommand = new TurnVolumeUp(radio);
            DeviceButton radioVolUpButton = new DeviceButton(radioVolUpcommand);
            radioVolUpButton.Press();
            radioVolUpButton.Press();
            radioVolUpButton.Press();
            radioVolUpButton.Press();
            radioVolUpButton.Press();

            TurnVolumeDown radioVolDowncommand = new TurnVolumeDown(radio);
            DeviceButton radioVolDownButton = new DeviceButton(radioVolDowncommand);
            radioVolDownButton.Press();
            radioVolDownButton.Press();

            radioOffButton.Press();

            Console.ReadLine();
        }
    }
}
