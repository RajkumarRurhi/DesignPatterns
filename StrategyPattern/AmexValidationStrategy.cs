using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class AmexValidationStrategy : ValidationStrategy
    {
        public override bool isValid(CreditCard creditCard)
        {
            bool isValid = false;

            isValid = creditCard.CardNumber.StartsWith("34") || creditCard.CardNumber.StartsWith("37");

            if (isValid)
            {
                isValid = creditCard.CardNumber.Length == 15;
            }

            if(isValid)
            {
                isValid = passesLuhn(creditCard.CardNumber);
            }

            return isValid;
        }
    }
}
