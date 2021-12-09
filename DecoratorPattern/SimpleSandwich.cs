using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class SimpleSandwich : Sandwich
    {
        public SimpleSandwich() { }
        public string Make()
        {
            return "Wheat Bread";
        }
    }
}
