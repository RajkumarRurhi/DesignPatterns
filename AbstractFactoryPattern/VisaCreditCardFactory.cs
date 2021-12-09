using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class VisaCreditCardFactory : CreditCardFactory
    {
        public override CreditCard CreateCreditCard(CardType cardType, string cardHolderName)
        {
            switch(cardType)
            {
                case CardType.PLATINUM:
                    return new VisaPlatinum(cardHolderName);
                case CardType.GOLD:
                    return new VisaGold(cardHolderName);
                default:
                    return null;
            }
        }
    }
}
