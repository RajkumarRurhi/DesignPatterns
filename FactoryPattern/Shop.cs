using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Shop : WebSite
    {
        public override void createWebSite()
        {
            this.pages.Add(new ShoppingCart());
            this.pages.Add(new Item());
            this.pages.Add(new Search());
        }
    }
}
