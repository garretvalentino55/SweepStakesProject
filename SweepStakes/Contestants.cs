using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestants
    {
        // member variables 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public int registrationNumber { get; set; }
        int newRegistrationNumber;
        int x;
        //constructor 
        public Contestants(string firstname , string lastname)
        {
            Contestants contestant = new Contestants(firstname, lastname);
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
        }


        public void GetContestantInfo()
        {
            firstName = Userinterface.GetFirstName();
            lastName = Userinterface.GetLastName();
            emailAddress = Userinterface.GetEmailAddress();
            SetRegistrationNumber();
        }

        // member methods 
        public int SetRegistrationNumber()
        {
            for (int i = 0; i < registrationNumber; i++)
            {
                newRegistrationNumber = i;

            }
            return newRegistrationNumber;
        }


    }
}
