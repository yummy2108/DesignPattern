using System;
using SimUDuck;
namespace SimUDuck
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public interface IQuackBehavior
    {
        void Quack();
    }
}