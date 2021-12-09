using System;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director mark = new Director();
            VicePresident glen = new VicePresident();
            CEO david = new CEO();

            mark.Successor = glen;
            glen.Successor = david;

            Request request1 = new Request(RequestType.CONFERENCE, 900);
            mark.HandleRequest(request1);

            Request request2 = new Request(RequestType.PURCHASE, 4000);
            mark.HandleRequest(request2);

            Request requet3 = new Request(RequestType.PURCHASE, 9000);
            mark.HandleRequest(requet3);

            Console.ReadLine();
        }
    }
}
