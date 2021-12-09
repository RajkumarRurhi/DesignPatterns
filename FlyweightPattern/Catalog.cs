using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    internal class Catalog
    {
        private Dictionary<string, Item> items = new Dictionary<string, Item>();

        public Item LookUp(string itemName)
        {
            if (items.ContainsKey(itemName))
            {
                return items[itemName];
            }
            else
            {
                Item item = new Item(itemName);
                items.Add(itemName, item);
                return item;
            }
        }

        public int TotalItemMade()
        {
            return items.Count;
        }
    }
}
