using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    internal class BankFacade
    {
        private readonly int accountNumber;
        private readonly int securityCode;
        ABCBank abcBank;
        AccountNumberCheck accountNumberChecker;
        FundCheck fundChecker;
        SecurityCodeCheck securityCodeChecker;

        public BankFacade(int accountNumber, int securityCode)
        {
            this.accountNumber = accountNumber;
            this.securityCode = securityCode;

            abcBank = new ABCBank();
            accountNumberChecker = new AccountNumberCheck();
            fundChecker = new FundCheck();
            securityCodeChecker = new SecurityCodeCheck();
        }

        public void WithdrawCash(decimal amount)
        {
            if(accountNumberChecker.IsAccountActive(accountNumber) && securityCodeChecker.IsCodeCorrect(securityCode) && fundChecker.WithdrawMoney(amount))
            {
                Console.WriteLine($"Transaction completed. Balance : {fundChecker.Balance}");
            }
            else
            {
                Console.WriteLine($"Transaction failed. Balance : {fundChecker.Balance}");
            }
        }

        public void DepositCash(decimal amount)
        {
            if (accountNumberChecker.IsAccountActive(accountNumber) && securityCodeChecker.IsCodeCorrect(securityCode))
            {
                fundChecker.DepositMoney(amount);
                Console.WriteLine($"Transaction completed. Balance : {fundChecker.Balance}");
            }
            else
            {
                Console.WriteLine($"Transaction failed. Balance : {fundChecker.Balance}");
            }
        }
    }
}
