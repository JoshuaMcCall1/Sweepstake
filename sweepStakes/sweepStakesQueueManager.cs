using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    public class sweepStakesQueueManager : IsweepStakesManager
    {
        //member variables
        Queue<SweepStakes> sweepstakesQueue;
        char Contestant;
 
        //constructor
        public sweepStakesQueueManager()
        {
            sweepstakesQueue = new Queue<SweepStakes>();
        }

        //member methods
        public void InsertSweepstakes(SweepStakes sweepstakesToInsert)// self reminder this means to add
        {
            sweepstakesQueue.Enqueue(sweepstakesToInsert);
        }
        public SweepStakes GetSweepstakes(SweepStakes sweepstakesToRemove)  // means remove!
        {
            sweepstakesQueue.Dequeue(sweepstakesToRemove);

        }
        
        
          
    }

    

}