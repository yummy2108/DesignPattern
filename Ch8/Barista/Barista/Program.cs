using System;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("Making tea. . .");
            tea.PrepareRecipe();

            Console.WriteLine("Making coffee. . .");
            coffee.PrepareRecipe();

            TeaWithHook teaWithHook = new TeaWithHook();
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();

            Console.WriteLine("Making tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine("Making coffee...");
            coffeeWithHook.PrepareRecipe();

        }
    }
}
