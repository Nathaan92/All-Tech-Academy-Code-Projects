//1) Your application must ask these questions:
//What is your age ?
//Have you ever had a DUI?
//How many speeding tickets do you have?
//2) Use the following qualification rules to determine if the applicant qualifies for car insurance:
//Applicants must be over 15 years old.
//Applicants must not have any DUI’s.
//Applicants must not have more than 3 speeding tickets.
//3) Print the result of the boolean expression created from the above business rules.


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int aAge = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string uIn = Console.ReadLine();
            string aIn = uIn.ToLower();
            bool noDUI = (aIn == "false");
            Console.WriteLine("How many speeding tickets do you have?");
            string NST = Console.ReadLine();
            int ANST = Convert.ToInt32(NST);
            Console.WriteLine("Qualified?");
            bool qualified = (aAge >= 15 && noDUI && ANST <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();




        }
    }
}
