using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Page
    {
        public Page()
        {
            Console.WriteLine("Page constructor invoked");
        }
    }
}
