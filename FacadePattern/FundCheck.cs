using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class FundCheck
    {
        decimal balance;

        public decimal Balance { get { return balance; } }

        public bool WithdrawMoney(decimal amout)
        {
            if(balance < amout)
            {
                Console.WriteLine("Withdrawl failed. Not enough balance in account.");
                return false;
            }
            else
            {
                balance -= amout;
                Console.WriteLine($"Withdrawl done.");
                return true;
            }
        }

        public void DepositMoney(decimal amout)
        {
            balance += amout;
            Console.WriteLine($"Deposit done.");
        }
    }
}
