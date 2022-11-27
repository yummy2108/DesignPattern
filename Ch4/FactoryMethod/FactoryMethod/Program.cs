using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("A order " + pizza.getName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("A order " + pizza.getName());
        }
    }
}
