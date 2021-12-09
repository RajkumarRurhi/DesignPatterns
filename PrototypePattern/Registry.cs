using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    internal class Registry
    {
        private Dictionary<string, Item> items = new Dictionary<string, Item>();
        public Registry()
        {
            LoadItems();
        }

        public Item CreateItem(string type)
        {
            Item item = null;
            try
            {
                item = items.GetValueOrDefault(type).Clone() as Item;                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            return item;
        }

        private void LoadItems()
        {
            Book book = new Book();
            book.Title = "Book 1";
            book.Price = 20;
            book.PageCount = 10;
            items.Add("Book", book);

            Movie movie = new Movie();
            movie.Title = "Movie 1";
            movie.Price = 10;
            movie.RunTime = "1:30 Mins";
            items.Add("Movie", movie);
        }
    }
}
