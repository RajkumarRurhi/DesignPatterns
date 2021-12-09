using System;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditCard amexCard = new CreditCard(new AmexValidationStrategy()){ CardNumber = "379185883464283", ExpirationDate = DateTime.Now.AddYears(3), Cvv = 123 };
            Console.WriteLine($"Is amex valid : {amexCard.IsValid()}");

            CreditCard amexCard2 = new CreditCard(new AmexValidationStrategy()) { CardNumber = "379185883464284", ExpirationDate = DateTime.Now.AddYears(3), Cvv = 123 };
            Console.WriteLine($"Is amex2 valid : {amexCard2.IsValid()}");

            CreditCard visaCard = new CreditCard(new VisaValidationStrategy()) { CardNumber = "4539589763663402", ExpirationDate = DateTime.Now.AddYears(3), Cvv = 321 };
            Console.WriteLine($"Is visa valid : {visaCard.IsValid()}");

            CreditCard visaCard2 = new CreditCard(new VisaValidationStrategy()) { CardNumber = "4539589763663401", ExpirationDate = DateTime.Now.AddYears(3), Cvv = 321 };
            Console.WriteLine($"Is visa2 valid : {visaCard2.IsValid()}");

            Console.ReadLine();
        }
    }
}
