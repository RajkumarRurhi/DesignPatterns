using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    internal class StoreOrder : OrderTemplate
    {
        public override void CheckOut()
        {
            Console.WriteLine("Take items from basket.");
        }

        public override void Delivery()
        {
            Console.WriteLine("Put items in bag on counter.");
            Console.WriteLine("Thank customer for shopping with us.");
        }

        public override void Payment()
        {
            Console.WriteLine("Process payment with card present.");
        }

        public override void Receipt()
        {
            Console.WriteLine("Print receipt.");
            Console.WriteLine("Keep receipt in items bag");
        }
    }
}
