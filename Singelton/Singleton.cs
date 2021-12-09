using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object padLock = new object();

        public static Singleton Instance {
            get
            {
                Console.WriteLine("Instance Called");
                if (_instance == null)
                {
                    lock (padLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Constructor called");
        }
    }
}
