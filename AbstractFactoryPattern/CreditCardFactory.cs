using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal abstract class CreditCardFactory
    {
        public static CreditCardFactory GetCreditCardFactory(int creditScore)
        {
            if(creditScore > 650)
            {
                return new AmexCreditCardFactory();
            }
            else
            {
                return new VisaCreditCardFactory();
            }
        }

        public abstract CreditCard CreateCreditCard(CardType cardType, string cardHolderName);
    }
}
