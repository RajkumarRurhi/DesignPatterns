using System;

namespace Singelton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var testString = Singleton2.Greetings;
            //Console.ReadLine();

            var inst1 = Singleton3.Instance;
            var inst2 = Singleton3.Instance;
            var inst3 = Singleton3.Instance;
            var inst4 = Singleton3.Instance;
            
            Console.ReadLine();
        }
    }
}
