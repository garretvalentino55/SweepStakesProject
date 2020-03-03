using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        // Member Variables 
        // dictionary
        Dictionary<int, Contestants> newContestants;
        int ContestantCount;
        int winningContestant;
        // Constructor 
        public SweepStakes()
        {
            newContestants = new Dictionary<int, Contestants>();    
        }

        // Member Method
        
        public void RegisterContestant(Contestants contestants)
        {
            ContestantCount++;
            newContestants.Add(ContestantCount, contestants);

        }
        public Contestants PickWinner()
        {
            int random = new Random().Next(1, ContestantCount);
            Contestants winningContestant = newContestants[random];
            return winningContestant;
        }
        
        public void PrintContestantInfo(Contestants contestants)
        {

        }
    }
}
