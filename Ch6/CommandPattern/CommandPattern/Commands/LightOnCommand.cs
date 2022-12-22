using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute() => this.light.On();
    }
}
