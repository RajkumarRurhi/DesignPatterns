using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    internal class Tobacco : IVisitable
    {
        private readonly decimal price;

        public Tobacco(decimal price)
        {
            this.price = price;
        }

        public decimal Price { get { return price; } }

        public decimal Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
