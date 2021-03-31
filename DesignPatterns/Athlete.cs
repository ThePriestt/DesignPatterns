using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public delegate void EventHandler(object sender, StateChangeEventArgs e);
    class Athlete
    {
        public event EventHandler StateChange;
        protected virtual void OnStateChange(StateChangeEventArgs e)
        {
            if (StateChange != null)
            {
                StateChange(this, e);
            }
        }
        public void Up() 
        {
            StateChangeEventArgs eventargs = new StateChangeEventArgs();
            eventargs.StateText = "I'm an athlete, i'm getting up !";
            
            OnStateChange(eventargs);
            Console.WriteLine("I am getting up");
        }

        public void Down()
        {
            StateChangeEventArgs eventargs = new StateChangeEventArgs();
            eventargs.StateText = "I'm an athlete, i'm getting down !";

            OnStateChange(eventargs);
            Console.WriteLine("I am getting down");
        }
    }
}
