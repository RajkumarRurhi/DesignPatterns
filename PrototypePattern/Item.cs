using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    internal abstract class Item : ICloneable
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Url { get; set; }

        public object Clone()
        {
            return base.MemberwiseClone() as Item;
        }
    }
}
