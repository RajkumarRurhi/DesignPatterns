using System;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light bedRoomRight = new Light("BedRoom");
            Light kitchenLight = new Light("Kitchen");
            Light livingRoom = new Light("Living Room");

            Mediator mediator = new Mediator();
            mediator.RegisterLight(bedRoomRight);
            mediator.RegisterLight(kitchenLight);
            mediator.RegisterLight(livingRoom);

            ICommand turnOnAllLights = new TurnOnAllLights(mediator);
            ICommand turnOffAllLights = new TurnOffAllLights(mediator);

            turnOnAllLights.Execute();
            turnOffAllLights.Execute();

            Console.ReadLine();
        }
    }
}
