using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(Request request);
    }
}
