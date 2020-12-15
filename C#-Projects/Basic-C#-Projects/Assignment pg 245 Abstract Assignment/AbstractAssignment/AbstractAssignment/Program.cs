using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.



namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "John";
            employee1.lastName = "Doe";
            employee1.ID = 1;
            employee1.SayName();

            Employee employee2 = new Employee();
            employee2.firstName = "Jonathan";
            employee2.lastName = "Doe";
            employee2.ID = 1;
            employee2.SayName();

            IQuittable iQuit = new Employee();
            iQuit.Quit();

            if (employee1==employee2)  
            {
                Console.WriteLine("Employee1 and Employee2 are the same person");
            }
            else if (employee1!=employee2)
            {
                Console.WriteLine("Employee1 and Employee2 are two diffrent people");
            } 

            Console.ReadLine();
        }
    }
}
