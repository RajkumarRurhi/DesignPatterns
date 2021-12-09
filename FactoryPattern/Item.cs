using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Item : Page
    {
        public Item()
        {
            Console.WriteLine("Item page created.");
        }
    }
}
