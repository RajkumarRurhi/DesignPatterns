using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class VisaValidationStrategy : ValidationStrategy
    {
        public override bool isValid(CreditCard creditCard)
        {
            bool isValid = false;

            isValid = creditCard.CardNumber.StartsWith("4");

            if (isValid)
            {
                isValid = creditCard.CardNumber.Length == 16;
            }

            if (isValid)
            {
                isValid = passesLuhn(creditCard.CardNumber);
            }

            return isValid;
        }
    }
}
