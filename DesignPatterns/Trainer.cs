using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Trainer 
    {
        public ICommand Command { get; set; }
        public Trainer(ICommand command)
        {
            Command = command;
        }

        public void Train()
        {
            Command.Execute();
        }
    }
}
