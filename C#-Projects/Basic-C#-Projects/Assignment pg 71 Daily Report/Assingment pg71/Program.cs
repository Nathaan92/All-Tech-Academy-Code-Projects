//Your job is to create a daily report (DR) for students of The Tech Academy.
//REQUIREMENTS:
//A.The program must start by printing “The Tech Academy.”
//B.The next line must be “Student Daily Report.”
//C.You must ask and save your data according to its proper data type and with clearly labeled variables.
//D.The DR must contain the following questions:
//What is your name ?
//What course are you on ?
//What page number ?
//Do you need help with anything ? Please answer “true” or “false.”
//Were there any positive experiences you’d like to share ? Please give specifics.
//Is there any other feedback you’d like to provide ? Please be specific.
//How many hours did you study today ?
//E.After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly.Have a great day!” This is the end of the program.

using System;

namespace Assingment_pg71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number ?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool needHalp = System.Convert.ToBoolean(needHelp);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExper = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrsStudied = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
