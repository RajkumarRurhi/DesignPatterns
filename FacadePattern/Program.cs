using System;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankFacade bankFacade = new BankFacade(987654321, 1234);

            bankFacade.DepositCash(100);
            bankFacade.WithdrawCash(50);
            bankFacade.WithdrawCash(75);
            bankFacade.DepositCash(100);
            bankFacade.WithdrawCash(75);

            Console.ReadLine();
        }
    }
}
