using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // Member variables 
        Queue<SweepStakes> queue;

        // Constructor
        public SweepstakesQueueManager()
        {
            Queue<SweepStakes> queue = new Queue<SweepStakes>();

        }


        //Member Methods 


        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
   
            queue.Enqueue(sweepStakes);
            
            
        }

        public SweepStakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
