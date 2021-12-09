using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public sealed class Singleton3
    {
        private static readonly Lazy<Singleton3> _instance = new Lazy<Singleton3>(() => new Singleton3());

        public static Singleton3 Instance 
        { 
            get 
            {
                Console.WriteLine("Instance called");
                return _instance.Value;
            } 
        }

        private Singleton3()
        {
            Console.WriteLine("Constructor Invoked");
        }
    }
}
