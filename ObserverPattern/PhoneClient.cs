using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class PhoneClient : Observer
    {
        public PhoneClient(Observable observable)
        {
            this.observable = observable;
            this.observable.Attach(this);
        }

        public void SendMessage(string message)
        {
            this.observable.SetState(message);
        }

        public override void Update()
        {
            Console.WriteLine("Phone client received message : " + this.observable.GetState());
        }
    }
}
