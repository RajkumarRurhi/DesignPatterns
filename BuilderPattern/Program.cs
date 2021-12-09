using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LunchOrder.Builder builder = new LunchOrder.Builder();
            builder.AddBread("Wheat").AddCondiments("Lettuce").AddDressing("Ranch").AddMeat("Chicken");

            LunchOrder lunchOrder = builder.Build();
            Console.WriteLine(lunchOrder.ToString());

            Console.ReadLine();
        }
    }
}
