using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    internal interface IVisitor
    {
        public decimal Visit(Liquor liquor);
        public decimal Visit(Tobacco tobacco);
        public decimal Visit(Necessity necessity);
    }
}
