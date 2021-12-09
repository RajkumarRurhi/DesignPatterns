using System;

namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxVisitor taxVisitor = new TaxVisitor();

            Necessity milk = new Necessity(3.5m);
            Liquor liquor = new Liquor(12m);
            Tobacco tobacco = new Tobacco(25m);

            Console.WriteLine("-------- Prices After tax----------");
            milk.Accept(taxVisitor);
            liquor.Accept(taxVisitor);
            tobacco.Accept(taxVisitor);

            Console.WriteLine("-------- Prices in tax holiday season----------");
            TaxHolidayVisitor taxHolidayVisitor = new TaxHolidayVisitor();
            milk.Accept(taxHolidayVisitor);
            liquor.Accept(taxHolidayVisitor);
            tobacco.Accept(taxHolidayVisitor);

            Console.ReadLine();
        }
    }
}
