using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute() => this.garageDoor.Up();
    }
}
