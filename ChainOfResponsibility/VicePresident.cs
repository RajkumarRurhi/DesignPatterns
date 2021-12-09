using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class VicePresident : Handler
    {
        public override void HandleRequest(Request request)
        {
            if(request.Amount <= 5000)
            {
                Console.WriteLine("Approved by vice president");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
