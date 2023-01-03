using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() { }
    }
}
