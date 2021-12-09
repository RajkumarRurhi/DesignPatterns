using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class CEO : Handler
    {
        public override void HandleRequest(Request request)
        {
            Console.WriteLine("Approved by CEO");
        }
    }
}
