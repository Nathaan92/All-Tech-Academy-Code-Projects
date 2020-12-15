using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Perform these actions and create a console app that includes the following:

//1. Asks the user for a number.

//2. Logs that number to a text file.

//3. Prints the text file back to the user.

namespace Assignment_pg_297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            using (StreamWriter numberLog = new StreamWriter(@"C:\Users\natha\Logs\Log.txt", true))
            {
                numberLog.WriteLine(number);
            }
            string populatedNumberLog = File.ReadAllText(@"C:\Users\natha\Logs\Log.txt");
            Console.WriteLine("Numbers that have been entered: \n" + populatedNumberLog);
            Console.Read();
        }
    }
}