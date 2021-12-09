using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sandwich sandwich = new DressingDecorator(new MeatDecorator(new SimpleSandwich()));
            Console.WriteLine(sandwich.Make());

            Console.ReadLine();
        }
    }
}
