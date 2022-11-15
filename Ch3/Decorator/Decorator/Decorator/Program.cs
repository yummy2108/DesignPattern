using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());

            beverage = new HouseBlend();
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());

            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());

            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost());
        }
    }
}
