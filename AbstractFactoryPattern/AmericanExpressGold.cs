using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class AmericanExpressGold : CreditCard
    {
        public AmericanExpressGold(string cardHolderName) : base(cardHolderName)
        {
        }
        public override string ToString()
        {
            return $" AMEX Gold Details: { CardHolderName} - {CardNumber} - {ExpirationDate} - {CVV}";
        }
    }
}
