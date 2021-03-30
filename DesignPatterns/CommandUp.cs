using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class CommandUp : ICommand
    {
        Athlete _athlete;
        public CommandUp(Athlete athlete)
        {
            _athlete = athlete;
        }
        public void Execute()
        {
            _athlete.Up();
        }
    }
}
