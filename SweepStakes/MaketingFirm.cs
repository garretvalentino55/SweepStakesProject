using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MaketingFirm : ISweepstakesManager
    {
        //member variables 



        //constructor 
        public MaketingFirm()
        {
            SweepStakes sweepStakes = new SweepStakes();
        }

        // member methods 
        public void CreateSweepstakes()
        {
            
        }

        public SweepStakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            throw new NotImplementedException();
        }
    }
}
