using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class Userinterface
    {
        
        
   
      
        public static string GetFirstName()
        {
            Console.WriteLine("Please Enter your First Name");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public static string GetLastName()
        {
            Console.WriteLine("Please Enter your Last Name");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public static string GetEmailAddress()
        {
            Console.WriteLine("Please Enter your Email Address");
            Console.ReadLine();
            return Console.ReadLine();
        }
        public static void GetUserInputFor()
        {
            GetFirstName();
            GetLastName();
            GetEmailAddress();
        }
    }
}
