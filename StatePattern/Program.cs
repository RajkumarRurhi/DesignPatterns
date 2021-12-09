using System;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan = new Fan();
            Console.WriteLine(fan.ToString());

            fan.PullChain();
            Console.WriteLine(fan.ToString());

            fan.PullChain();
            Console.WriteLine(fan.ToString());

            fan.PullChain();
            Console.WriteLine(fan.ToString());

            fan.PullChain();
            Console.WriteLine(fan.ToString());

            Console.ReadLine();
        }
    }
}
