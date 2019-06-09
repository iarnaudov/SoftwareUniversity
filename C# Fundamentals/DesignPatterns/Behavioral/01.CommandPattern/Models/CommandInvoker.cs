using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    class CommandInvoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }

    }
}
