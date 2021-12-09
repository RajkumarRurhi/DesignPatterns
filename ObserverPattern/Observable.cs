using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal abstract class Observable
    {
        List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract void SetState(string message);

        public abstract string GetState();

        public void NotifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
