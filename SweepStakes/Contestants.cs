using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestants
    {
        // member variables 
        public string firstName { get; set; }
        public string lastName { get; set; }
        string emailAddress { get; set; }
        int registrationNumber { get; set; }
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




        // member methods 

        public string GetFirstName()
        {
            Console.WriteLine("Please Enter your First Name");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public string GetLastName()
        {
            Console.WriteLine("Please Enter your Last Name");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public string GetEmailAddress()
        {
            Console.WriteLine("Please Enter your Email Address");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public int SetRegistrationNumber()
        {
            Random random = new Random();
            random.Next(1, 10000);
            int x = random.Next(1, 10000);
            return x;


        }
        public void GetConstestantInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmailAddress();
            SetRegistrationNumber();
            

        }

    }
}
