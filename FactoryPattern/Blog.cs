using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Blog : WebSite
    {
        public override void createWebSite()
        {
            this.Pages.Add(new AboutUs());
            this.Pages.Add(new ContactUs());
            this.Pages.Add(new Post());
        }
    }
}
