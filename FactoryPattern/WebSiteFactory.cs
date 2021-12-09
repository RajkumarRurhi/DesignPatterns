using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class WebSiteFactory
    {
        public static WebSite CreateWebSite(WebSiteType webSiteType)
        {
            switch (webSiteType)
            {
                case WebSiteType.Blog:
                    return new Blog();
                case WebSiteType.Shop:
                    return new Shop();
                default:
                    return null;
            }
            
        }
    }
}
