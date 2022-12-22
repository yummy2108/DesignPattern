using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Receivers
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Open");

        public void Down() => Console.WriteLine("Garage Door is Down");

        public void Stop() => Console.WriteLine("Garage Door is Stop");

        public void LightOn() => Console.WriteLine("Garage light is on");

        public void LightOff() => Console.WriteLine("Garage light is off");
    }
}
