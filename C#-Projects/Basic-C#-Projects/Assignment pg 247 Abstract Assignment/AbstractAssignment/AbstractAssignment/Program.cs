using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. make the employee class take a generic type parameter.

//2. add a property to the employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3. instantiate an employee object with type "string" as its generic parameter. assign a list of strings as the property value of things.

//4. instantiate an employee object with type "int" as its generic parameter. assign a list of integers as the property value of things.

//5. create a loop that prints all of the things to the console.



namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.firstName = "John";
            employee1.lastName = "Doe";
            employee1.ID = 1;
            employee1.Things.Add("Alpha");
            employee1.Things.Add("Bravo");
            employee1.Things.Add("Charlie");
            employee1.Things.Add("Delta");
            employee1.Things.Add("Echo");
            employee1.SayName();

            Employee<int> employee2 = new Employee<int>();
            employee2.firstName = "Jonathan";
            employee2.lastName = "Doe";
            employee2.ID = 2;
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);
            employee2.Things.Add(4);
            employee2.Things.Add(5);
            employee2.SayName();

            Employee<string> employee3 = new Employee<string>();
            employee1.firstName = "John";
            employee1.lastName = "Doe";
            employee1.ID = 1;

            IQuittable iQuit = new Employee<string>();
            iQuit.Quit();

            if (employee1==employee3)  
            {
                Console.WriteLine("Employee1 and Employee2 are the same person");
            }
            else if (employee1!=employee3)
            {
                Console.WriteLine("Employee1 and Employee2 are two diffrent people");
            } 

             foreach (string Thing in employee1.Things)
            {
                Console.WriteLine(Thing);
            }
            foreach (int Thing in employee2.Things)
            {
                Console.WriteLine(Thing);
            }

            Console.ReadLine();
        }
    }
}
