using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    internal class Square : Shape
    {
        public Square(Color color) : base(color)
        {  
        }

        public override void applyColor()
        {
            Console.WriteLine(color.applyColor() + " to square");
        }
    }
}
