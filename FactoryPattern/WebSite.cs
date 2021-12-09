using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class WebSite
    {
        protected List<Page> pages = new List<Page>();

        public WebSite()
        {
            this.createWebSite();
        }

        public List<Page> Pages { get { return pages; } }

        public abstract void createWebSite();
    }
}
