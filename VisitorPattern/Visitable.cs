using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    internal interface IVisitable
    {
        decimal Accept(IVisitor visitor);
    }
}
