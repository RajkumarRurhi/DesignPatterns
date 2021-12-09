using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class AmericanExpressPlatinum : CreditCard
    {
        public AmericanExpressPlatinum(string cardHolderName): base(cardHolderName)
        {
        }
        public override string ToString()
        {
            return $" AMEX Platinum Details: { CardHolderName} - {CardNumber} - {ExpirationDate} - {CVV}";
        }
    }
}
