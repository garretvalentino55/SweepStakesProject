using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables 
        Stack<SweepStakes> stack;

        // Constructor 
        public SweepstakesStackManager()
        {
            Stack<SweepStakes> stack = new Stack<SweepStakes>();
        }

        //Member Methods
        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }

        public SweepStakes GetSweepstakes()
        {
            return stack.Pop();
        }

    }
}
