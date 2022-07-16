using System;
using SimUDuck;
namespace SimUDuck
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;

        public Duck() {}

        public abstract void display();

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
        public void performFly() {
            this.flyBehavior.Fly();
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
        public void performQuack() {
            this.quackBehavior.Quack();
        }

        public void swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}