using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class CommandDown : ICommand
    {
        Athlete _athlete;
        public CommandDown(Athlete athlete)
        {
            _athlete = athlete;
        }
        public void Execute()
        {
            _athlete.Down();
        }
    }
}
