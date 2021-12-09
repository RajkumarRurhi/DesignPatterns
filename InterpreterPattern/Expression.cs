using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    internal interface Expression
    {
        public Boolean Interpret(string context);
    }
}
