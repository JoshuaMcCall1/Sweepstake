using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
     public interface IsweepStakesManager
     {

        void InsertSweepstakes(SweepStakes sweepstakesToInsert);

        SweepStakes GetSweepstakes();
     }
}