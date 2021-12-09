using System;

namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string context = "Lions";
            //string context = "Tigers";
            //string context = "Bears";
            //string context = "Lions Tigers";
            //string context = "Lions Bears";
            //string context = "Tigers Bears";

            Expression define = buildInterpreterTree();
            Console.WriteLine(context + " is " + define.Interpret(context));

            Console.ReadLine();
        }

        private static Expression buildInterpreterTree()
        {
            Expression e1 = new TerminalExpression("Lions");
            Expression e2 = new TerminalExpression("Tigers");
            Expression e3 = new TerminalExpression("Bears");

            Expression a1 = new AndExpression(e2, e3);
            Expression a2 = new OrExpression(e1, a1);

            return a2;
            //return new AndExpression(e3, a2);
        }
    }
}
