using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SubjectsFactory subjectsFactory = new SubjectsFactory();
            Athlete athlete = subjectsFactory.CreateAthelete();
            Observer observer1 = subjectsFactory.CreateObserver();
            Observer observer2 = subjectsFactory.CreateObserver();
            Observer observer3 = subjectsFactory.CreateObserver();

            athlete.StateChange += observer1.Update;
            athlete.StateChange += observer2.Update;
            athlete.StateChange += observer3.Update;

            CommandUp commandUp = new CommandUp(athlete);
            CommandDown commandDown = new CommandDown(athlete);
            Trainer trainer = subjectsFactory.CreateTrainer();
            trainer.Command = commandUp;
            trainer.Train();
            trainer.Command = commandDown;
            trainer.Train();
        }
    }
}
