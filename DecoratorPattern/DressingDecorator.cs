using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class DressingDecorator : SandwichDecorator
    {
        public DressingDecorator(Sandwich sandwich) : base(sandwich)
        {
        }

        public override string Make()
        {
            return sandwich.Make() + addDressing();
        }

        private string addDressing()
        {
            return " + Mustard";
        }
    }
}
