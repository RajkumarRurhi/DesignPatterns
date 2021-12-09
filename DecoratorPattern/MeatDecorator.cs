using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class MeatDecorator : SandwichDecorator
    {
        public MeatDecorator(Sandwich sandwich) : base(sandwich)
        {
        }

        public override string Make()
        {
            return sandwich.Make() + addMeat();
        }

        private string addMeat()
        {
            return " + Chicken";
        }
    }
}
