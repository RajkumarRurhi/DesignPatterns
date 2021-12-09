using System;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRepo repo = new CarRepo();
            repo.addCar("Toyota");
            repo.addCar("Honda");
            repo.addCar("chevrolet");
            repo.addCar("Nissan");

            var iterator = repo.GetEnumerator();
            do
            {
                Console.WriteLine(iterator.Current);
            } while (iterator.MoveNext());

            iterator.Reset();
            Console.WriteLine("------- Another iteration after resetting -------");
            do
            {
                Console.WriteLine(iterator.Current);
            } while (iterator.MoveNext());

            Console.ReadLine();
        }
    }
}
