using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public sealed class Singleton2
    {
        public static readonly string Greetings = "Hello!";

        public static Singleton2 Instance
        {
            get
            {
                Console.WriteLine("Instance called");
                return Nested._instance;
            }
        }
        private class Nested
        {
            static Nested() { Console.WriteLine("Nested constructor invoked"); }
            internal static readonly Singleton2 _instance = new Singleton2();
        }

        static Singleton2()
        {
            Console.WriteLine("Constructor Invoked");
        }
    }
}
