using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Blog : WebSite
    {
        public override void createWebSite()
        {
            this.pages.Add(new AboutUs());
            this.pages.Add(new ContactUs());
            this.pages.Add(new Post());
        }
    }
}
