using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{


    public class StackManager : IsweepStakesManager
    {
        // registerContestant RegistrationNumber;
        Stack<SweepStakes> sweepstakesStack = new Stack<SweepStakes>();
         public int registrationNumber;



        //constructor
        //public sweepStakesStackManager() => sweepstakesStack = new Stack<SweepStakes>();

        //member methods
        public void InsertSweepstakes(SweepStakes sweepstakesToInsert)
        {
            sweepstakesStack.Push(sweepstakesToInsert);
        }
        // self reminder this means to add
        public SweepStakes GetSweepstakes()  // means remove!
        {
            var thing = sweepstakesStack.Pop();

            return thing;
        }

       
    }



}
