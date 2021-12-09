using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Post : Page
    {
        public Post()
        {
            Console.WriteLine("Post page created.");
        }
    }
}
