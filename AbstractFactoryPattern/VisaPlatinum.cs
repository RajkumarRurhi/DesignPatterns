using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class VisaPlatinum : CreditCard 
    {
        public VisaPlatinum(string cardHolderName) : base(cardHolderName)
        {
        }
        public override string ToString()
        {
            return $" Visa Platinum Details: { CardHolderName} - {CardNumber} - {ExpirationDate} - {CVV}";
        }
    }
}
