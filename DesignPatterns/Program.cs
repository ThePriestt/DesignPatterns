using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete();
            CommandUp commandUp = new CommandUp(athlete);
            CommandDown commandDown = new CommandDown(athlete);
            Trainer trainer = new Trainer(commandUp);
            trainer.Train();
            trainer.Command = commandDown;
            trainer.Train();
        }
    }
}
