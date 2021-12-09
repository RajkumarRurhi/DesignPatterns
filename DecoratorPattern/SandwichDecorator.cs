using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            this.sandwich = sandwich;
        }

        public abstract string Make();
    }
}
