using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    internal class AmexCreditCardFactory : CreditCardFactory
    {
        public override CreditCard CreateCreditCard(CardType cardType, string cardHolderName)
        {
            switch (cardType)
            {
                case CardType.PLATINUM:
                    return new AmericanExpressPlatinum(cardHolderName);
                case CardType.GOLD:
                    return new AmericanExpressGold(cardHolderName);
                default:
                    return null;
            }
        }
    }
}
