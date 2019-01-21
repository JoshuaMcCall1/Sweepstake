using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    class marketingFirm
    {
        //implement dependency injection in my MarketingFirm class so that I can utilize a sweepstakes manager
        //Member Variables
        public string Stackname;
        public string Contestant;
        int registrationNumber;
        public IsweepStakesManager sweepstakesManager;
        
        //Constructors
        public marketingFirm(string Stackname, string Contestant, int registrationNumber)
        {
            this.Stackname = Stackname;
            this.Contestant = Contestant;
            this.registrationNumber = registrationNumber;
        }
        // Member Methods
        public void DisplayStatus()
        {

        }
    }
}
 
