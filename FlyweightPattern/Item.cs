using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    internal class Item
    {
        private readonly string name;

        public Item(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
