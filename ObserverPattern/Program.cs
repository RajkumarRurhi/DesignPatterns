using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observable observable = new MessageStream();

            PhoneClient ph = new PhoneClient(observable);
            TabletClient tb = new TabletClient(observable);
            DesktopClient dc = new DesktopClient(observable);

            ph.SendMessage("Message from phone");
            tb.SendMessage("Message from tablet");
            dc.SendMessage("Message from desktop");

            Console.ReadLine();
        }
    }
}
