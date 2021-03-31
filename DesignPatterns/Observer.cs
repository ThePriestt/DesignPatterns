using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Observer
    {
        public void Update(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("I'm an observer and i have been notified");
            Console.WriteLine(e.StateText);
        }
    }
}
