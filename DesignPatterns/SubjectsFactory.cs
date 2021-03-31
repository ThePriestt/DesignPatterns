using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SubjectsFactory
    {
        public Athlete CreateAthelete()
        {
            return new Athlete();
        }

        public Observer CreateObserver()
        {
            return new Observer();
        }

        public Trainer CreateTrainer()
        {
            return new Trainer();
        }
    }
}
