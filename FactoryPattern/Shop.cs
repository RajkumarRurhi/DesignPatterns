using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Shop : WebSite
    {
        public override void createWebSite()
        {
            this.Pages.Add(new ShoppingCart());
            this.Pages.Add(new Item());
            this.Pages.Add(new Search());
        }
    }
}
