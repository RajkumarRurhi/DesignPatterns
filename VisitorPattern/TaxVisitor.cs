using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    internal class TaxVisitor : IVisitor
    {
        public decimal Visit(Liquor liquor)
        {
            decimal priceAfterTax = liquor.Price * 1.2m;
            Console.WriteLine($"Liquor price with tax : {priceAfterTax}");
            return priceAfterTax;
        }

        public decimal Visit(Tobacco tobacco)
        {
            decimal priceAfterTax = tobacco.Price * 1.35m;
            Console.WriteLine($"Tobacco price with tax : {priceAfterTax}");
            return priceAfterTax;
        }

        public decimal Visit(Necessity necessity)
        {
            decimal priceAfterTax = necessity.Price * 1m;
            Console.WriteLine($"Necessity price with tax : {priceAfterTax}");
            return priceAfterTax;
        }
    }
}
