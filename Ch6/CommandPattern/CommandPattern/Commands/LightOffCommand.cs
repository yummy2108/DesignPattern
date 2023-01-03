using CommandPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute() => this.light.Off();
    }
}
