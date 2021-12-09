using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class TabletClient : Observer
    {
        public TabletClient(Observable observable)
        {
            this.observable = observable;
            this.observable.Attach(this);
        }

        public void SendMessage(string message)
        {
            observable.SetState(message);
        }
        public override void Update()
        {
            Console.WriteLine("Tablet client received message : " + observable.GetState());
        }
    }
}
