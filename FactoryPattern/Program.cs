using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite shoppingSite = WebSiteFactory.CreateWebSite(WebSiteType.Shop);

            WebSite blogSite = WebSiteFactory.CreateWebSite(WebSiteType.Blog);

            Console.ReadLine();
        }
    }
}
