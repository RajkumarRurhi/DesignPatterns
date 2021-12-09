using System;

namespace AbstractFactoryPattern
{
    public abstract class CreditCard
    {
        public CreditCard(string cardHolderName)
        {
            CardNumber = Guid.NewGuid().ToString().ToUpper();
            CardHolderName = cardHolderName;
            ExpirationDate = DateTime.Now.Date.AddYears(4);
            CVV = (new Random()).Next(100, 999);
        }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int CVV { get; set; }

    }
}