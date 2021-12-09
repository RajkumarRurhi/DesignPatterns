using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal class WebOrder : OrderTemplate
    {
        public override void CheckOut()
        {
            Console.WriteLine("Get items from cart.");
            Console.WriteLine("Set gift preference.");
            Console.WriteLine("Set delivery address.");
            Console.WriteLine("Set billing address.");
        }

        public override void Delivery()
        {
            Console.WriteLine("Shipped the item to customer address.");
        }

        public override void Payment()
        {
            Console.WriteLine("Payment done without card being present.");
        }

        public override void Receipt()
        {
            Console.WriteLine("Receipt added in the delivery box.");
        }
    }
}
