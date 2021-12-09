using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory creditCardFactory = CreditCardFactory.GetCreditCardFactory(600);
            CreditCard creditCard = creditCardFactory.CreateCreditCard(CardType.GOLD, "David");
            Console.WriteLine(creditCard);

            creditCardFactory = CreditCardFactory.GetCreditCardFactory(700);
            CreditCard creditCard2 = creditCardFactory.CreateCreditCard(CardType.PLATINUM, "Mark");
            Console.WriteLine(creditCard2);

            Console.ReadLine();
        }
    }
}
