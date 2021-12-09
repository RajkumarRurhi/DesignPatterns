using System;

namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.TakeOrder("TV", 1);
            inventory.TakeOrder("SmartPhone", 2);
            inventory.TakeOrder("SmartWatch", 3);
            inventory.TakeOrder("TV", 4);
            inventory.TakeOrder("SmartPhone", 5);
            inventory.TakeOrder("SmartWatch", 6);
            inventory.TakeOrder("TV", 7);
            inventory.TakeOrder("SmartPhone", 8);
            inventory.TakeOrder("SmartWatch", 9);
            inventory.TakeOrder("TV", 10);
            inventory.TakeOrder("SmartPhone", 11);
            inventory.TakeOrder("SmartWatch", 12);

            inventory.ProcessOrders();

            Console.WriteLine(inventory.Report());

            Console.ReadLine();
        }
    }
}
