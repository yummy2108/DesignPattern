using System;
using SimUDuck;

namespace SimUDuck
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings.");
        }
    }

    public class FlyWithJetPropulsion : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("WHOOOOOOSH!");
        }
    }
}