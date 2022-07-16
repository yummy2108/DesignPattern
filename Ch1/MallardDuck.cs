using System;
using SimUDuck;
namespace SimUDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            setFlyBehavior(new FlyWithWings());
            setQuackBehavior(new QuackLikeMallard());
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
}