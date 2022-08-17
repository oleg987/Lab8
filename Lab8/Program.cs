using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Toy> toys = new List<Toy>();

            // 1.

            toys.Add(new Toy("Barbie", 125.6m, 5));
            toys.Add(new Toy("Tractor", 100m, 5));
            toys.Add(new Toy("Lego", 225.6m, 5));
            toys.Add(new Toy("Race car", 125.6m, 5));
            toys.Add(new Toy("Airplane", 325.6m, 5));

            // 2.
            Print(toys);

            // 3.
            toys.Insert(2, new Toy("Boat", 54.9m, 3));

            // 4.
            toys = toys.OrderBy(t => t.Title).ToList();

            // 5.
            Console.WriteLine("-------------");
            Print(toys);

            // 6.
            Console.WriteLine("-------------");
            toys = toys.OrderByDescending(t => t.Title).ToList();

            // 7.
            Console.WriteLine("------------");

            PrintByIterator(toys);

            // 8.

            toys.Insert(2, new Toy("Cubes", 14.9m, 15));

            // 9.

            toys = toys.OrderByDescending(t => t.Title).ToList();

            // 10.
            Console.WriteLine("------------");
            Print(toys);

            // 11.
            toys = toys.OrderByDescending(t => t.Title).ToList();

            // 12.
            Console.WriteLine("------------");
            Print(toys);

            // 13.

            int counter = toys.Count(t => t.Quantity == 5);
            Console.WriteLine(counter);
        }

        static void PrintByIterator(List<Toy> toys)
        {
            IEnumerator<Toy> enumerator = toys.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        static void Print(List<Toy> list)
        {
            foreach (Toy toy in list)
            {
                Console.WriteLine(toy);
            }
        }
    }
}
