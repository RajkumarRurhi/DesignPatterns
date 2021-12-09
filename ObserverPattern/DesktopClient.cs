using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal class DesktopClient : Observer
    {
        public DesktopClient(Observable observable)
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
            Console.WriteLine("Desktop client received message : " + observable.GetState());
        }
    }
}
