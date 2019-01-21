using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepStakes
{
    public class Contestant
    {
       int firstName;
       int lastName;
       public string userName;

        public Contestant (int firstName, string userName, int lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
        }

        public void thing()
        {
           
        }

      
        
        
   

    }

    
}
