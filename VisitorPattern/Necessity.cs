using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    internal class Necessity : IVisitable
    {
        private readonly decimal price;

        public Necessity(decimal price)
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
