using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    internal class Request
    {
        private readonly RequestType requestType;
        private readonly decimal amount;

        public Request(RequestType requestType, Decimal amount)
        {
            this.requestType = requestType;
            this.amount = amount;
        }

        public RequestType RequestType { get { return requestType; } }

        public decimal Amount { get { return amount; } }
    }
}
