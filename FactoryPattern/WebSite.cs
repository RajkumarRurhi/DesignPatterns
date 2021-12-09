using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class WebSite
    {
        public List<Page> Pages = new List<Page>();

        public WebSite()
        {
            this.createWebSite();
        }

        public abstract void createWebSite();
    }
}
