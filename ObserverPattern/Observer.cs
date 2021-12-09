using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    internal abstract class Observer
    {
        public Observable observable;
        public abstract void Update();
    }
}
