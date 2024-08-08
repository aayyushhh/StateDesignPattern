using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDemo.Models
{
    internal class Context
    {
        State state;

        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
