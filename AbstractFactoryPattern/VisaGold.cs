using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class VisaGold : CreditCard
    {
        public VisaGold(string cardHolderName) : base(cardHolderName)
        {
        }
        public override string ToString()
        {
            return $" Visa gold Details: { CardHolderName} - {CardNumber} - {ExpirationDate} - {CVV}";
        }
    }
}
