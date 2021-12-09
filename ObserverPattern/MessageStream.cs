using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class MessageStream : Observable
    {
        Stack<string> msgStk = new Stack<string>();
        public override string GetState()
        {
            return msgStk.Peek();
        }

        public override void SetState(string message)
        {
            msgStk.Push(message);
            NotifyObservers();
        }
    }
}
