using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    internal class AndExpression : Expression
    {
        private readonly Expression exp1;
        private readonly Expression exp2;

        public AndExpression(Expression exp1, Expression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }
        public bool Interpret(string context)
        {
            return exp1.Interpret(context) && exp2.Interpret(context);
        }
    }
}
