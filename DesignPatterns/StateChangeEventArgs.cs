using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class StateChangeEventArgs : EventArgs
    {
        public string StateText { get; set; }
    }
}
