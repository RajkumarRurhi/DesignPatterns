using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    internal class TerminalExpression : Expression
    {
        private readonly string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            String[] st = context.Split(" ");
            foreach(string s in st)
            {
                if (s.Equals(data))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
