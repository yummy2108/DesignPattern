using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private static readonly Lazy<ChocolateBoiler> Lazy =
            new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

        public static ChocolateBoiler Instance => Lazy.Value;

        private bool Empty;
        private bool Boiled;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                Console.WriteLine("Fill the boiler with a milk/chocolate mixture.");
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Console.WriteLine("Drain the boiled milk and chocolate.");
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Console.WriteLine("Bring the contents to a boil.");
                Boiled = true;
            }
        }
    }
}
