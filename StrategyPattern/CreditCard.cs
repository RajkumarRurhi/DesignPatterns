using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    internal class CreditCard
    {
        private readonly ValidationStrategy validationStrategy;

        public string CardNumber { get; set; }
        public int Cvv { get; set; }
        public DateTime ExpirationDate { get; set; }

        public CreditCard(ValidationStrategy validationStrategy)
        {
            this.validationStrategy = validationStrategy;
        }

        public bool IsValid()
        {
            return validationStrategy.isValid(this);
        }
    }
}
