using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Registry registry = new Registry();

            Movie movie = registry.CreateItem("Movie") as Movie;
            movie.Title = "Updated movie title";
            Console.WriteLine(movie.ToString() + movie.GetHashCode());
            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Price);

            Movie movie2 = registry.CreateItem("Movie") as Movie;
            movie2.Title = "Updated movie title 2";
            Console.WriteLine(movie2.ToString() + movie2.GetHashCode());
            Console.WriteLine(movie2.Title);
            Console.WriteLine(movie2.Price);

            Book book = registry.CreateItem("Book") as Book;
            book.Title = "Updated book title";
            Console.WriteLine(book.ToString() + book.GetHashCode());
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Price);

            Book book2 = registry.CreateItem("Book") as Book;
            book2.Title = "Updated book title 2";
            Console.WriteLine(book2.ToString() + book2.GetHashCode());
            Console.WriteLine(book2.Title);
            Console.WriteLine(book2.Price);

            Console.ReadLine();
        }
    }
}
