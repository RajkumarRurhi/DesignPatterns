using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    internal class Circle : Shape
    {
        public Circle(Color color) : base(color)
        {
        }

        public override void applyColor()
        {
            Console.WriteLine(this.color.applyColor() + " to circle");
        }
    }
}
