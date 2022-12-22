using CommandPattern.Commands;
using CommandPattern.Receivers;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var remote = new Invokers.SimpleRemoteControl();
            var light = new Light();
            var garageDoor = new GarageDoor();

            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageDoorOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}
