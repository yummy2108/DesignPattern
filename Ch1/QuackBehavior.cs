using System;
using SimUDuck;

namespace SimUDuck
{
    public class QuackLikeMallard : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class QuackLikeSpaniel : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Woof!");
        }
    }
}