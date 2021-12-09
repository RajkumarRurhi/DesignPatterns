using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    internal class Order
    {
        private readonly Item item;
        private readonly int orderId;

        public Order(int orderId, Item item)
        {
            this.item = item;
            this.orderId = orderId;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Ordering {item} for order number {orderId}");
        }
    }
}
