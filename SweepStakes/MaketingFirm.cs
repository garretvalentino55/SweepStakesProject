using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MaketingFirm 
    {
        //member variables 
        ISweepstakesManager _manager;


        //constructor 
        public MaketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        // member methods 
        public void CreateSweepstakes()
        {
            SweepStakes sweepStakes = new SweepStakes();
            _manager.InsertSweepstakes(sweepStakes);

        }
    }
}
