using System;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderTemplate webOrder = new WebOrder();
            Console.WriteLine("Web Order : ");
            webOrder.ProcessOrder();

            OrderTemplate storeOrder = new StoreOrder();
            Console.WriteLine("Store Order : ");
            storeOrder.ProcessOrder();

            Console.ReadLine();
        }
    }
}
