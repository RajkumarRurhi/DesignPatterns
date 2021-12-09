using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    internal class Inventory
    {
        Catalog catalog = new Catalog();
        List<Order> orders = new List<Order>();

        public void TakeOrder(string itemName, int orderId)
        {
            Item item = catalog.LookUp(itemName);
            Order order = new Order(orderId, item);
            orders.Add(order);
        }

        public void ProcessOrders()
        {
            foreach (Order order in orders)
            {
                order.ProcessOrder();
            }
            //orders.Clear();
        }

        public string Report()
        {
            return $"Total objects made : {catalog.TotalItemMade()}";
        }
    }
}
