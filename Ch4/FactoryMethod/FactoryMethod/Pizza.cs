using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string name { get; set; }
        public string dough { get; set; }
        public string sauce { get; set; }
        public List<string> toppings { get; set; } = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + this.name);
            Console.WriteLine("Tossing dough ... ");
            Console.WriteLine("Adding sauce ... ");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in this.toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degree");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public string getName()
        {
            return this.name;
        }
    }
}
