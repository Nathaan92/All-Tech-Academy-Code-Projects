//1.The program must start by printing “Anonymous Income Comparison Program” to the screen.
//2. It must then print “Person 1” to the screen and get the following details:
//Hourly Rate
//Hours worked per week
//3. It must then print “Person 2” to the screen and then get the following details:
//Hourly rate
//Hours worked per week
//4. It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
//5. It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
//6. It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

using System;

namespace Assignment_Pg_89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anomymous INcome Comparision Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            String P1HRSTR = Console.ReadLine();
            int P1HRINT = Convert.ToInt32(P1HRSTR);

            Console.WriteLine("Hours worked per week?");
            String P1HWSTR = Console.ReadLine();
            int P1HWINT = Convert.ToInt32(P1HWSTR);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            String P2HRSTR = Console.ReadLine();
            int P2HRINT = Convert.ToInt32(P2HRSTR);

            Console.WriteLine("Hours worked per week?");
            String P2HWSTR = Console.ReadLine();
            int P2HWINT = Convert.ToInt32(P2HWSTR);

            Console.WriteLine("Annual salary of Person 1:");
            int WSP1 = P1HRINT * P1HWINT;
            int ASP1 = WSP1 * 52;
            Console.WriteLine(ASP1);

            Console.WriteLine("Annual salary of Person 2:");
            int WSP2 = P2HRINT * P2HWINT;
            int ASP2 = WSP2 * 52;
            Console.WriteLine(ASP2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = ASP1 > ASP2;
            Console.WriteLine(trueOrFalse);

            Console.ReadLine();

        }
    }
}
