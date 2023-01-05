using System;
using System.Collections.Generic;

namespace DuckSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting: ");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("After sorting:");
            Display(ducks);
        }

        public static void Display(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
