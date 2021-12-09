using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provisioning shopping website.");
            WebSite shoppingSite = WebSiteFactory.CreateWebSite(WebSiteType.Shop);

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("Provisioning blog website.");
            WebSite blogSite = WebSiteFactory.CreateWebSite(WebSiteType.Blog);

            Console.ReadLine();
        }
    }
}
