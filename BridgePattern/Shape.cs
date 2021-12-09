using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    internal abstract class Shape
    {
        protected readonly Color color;

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract void applyColor();
    }
}
