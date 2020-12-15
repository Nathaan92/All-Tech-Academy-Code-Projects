using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a const variable.

//2. Create a variable using the keyword "var.”

//3. Chain two constructors together.

namespace Assignment_pg_310_Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            const string whoAmI = "Nate";
            var MyNameIs = whoAmI;
            Console.WriteLine(MyNameIs);


            Console.WriteLine("If your willing, please provide your full name. Otherwise press enter: ");
            string me = Console.ReadLine();
            Console.WriteLine("Enter your favorite color: ");
            string color = Console.ReadLine();
            Person thisIsMe = new Person(color);
            Console.ReadLine();
        }
    }
}
