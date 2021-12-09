using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class Director : Handler
    {
        public override void HandleRequest(Request request)
        {
            if(request.RequestType == RequestType.CONFERENCE && request.Amount <= 1000)
            {
                Console.WriteLine("Approved by director");
            }
            else
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
