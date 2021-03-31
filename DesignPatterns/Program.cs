using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete();
            Observer observer1 = new Observer();
            Observer observer2 = new Observer();
            Observer observer3 = new Observer();

            athlete.StateChange += observer1.Update;
            athlete.StateChange += observer2.Update;
            athlete.StateChange += observer3.Update;

            CommandUp commandUp = new CommandUp(athlete);
            CommandDown commandDown = new CommandDown(athlete);
            Trainer trainer = new Trainer(commandUp);
            trainer.Train();
            trainer.Command = commandDown;
            trainer.Train();
        }
    }
}
