using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Invokers
{
    public class SimpleRemoteControl
    {
        private ICommand slot;

        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            this.slot.Execute();
        }
    }
}
