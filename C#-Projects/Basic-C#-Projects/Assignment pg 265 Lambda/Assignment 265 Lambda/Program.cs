using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Perform the same action again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

namespace Assignment_265_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<string> Fnames = new List<string>() { "George", "Bob", "Phile", "Joe", "Joe", "Jan", "Heather", "Sasha", "Kira", "Cynthia" };
            List<string> Lnames = new List<string>() { "McGeorge", "Bily", "Tom", "Joey", "Jack", "Rope", "Tree", "Sea", "Kite", "Orange" };
                 
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee();
                emp.Fname = Fnames[i];
                emp.Lname = Lnames[i];
                emp.Id = i++;
                employees.Add(emp);
            }

            List<Employee> theJoes = new List<Employee>();

            //foreach (Employee employee in employees)
            //{
            //    if (employee.Fname == "Joe")
            //    {
            //        theJoes.Add(employee);
            //    }
            //}

            theJoes = employees.Where(x => x.Fname == "Joe").ToList();

            Console.WriteLine("Employees whos names is Joe");
            foreach (Employee emp in theJoes)
            {
                Console.WriteLine(emp.Fname + " " + emp.Lname);
            }

            List<Employee> over5 = new List<Employee>();

            over5 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\nEmployees whos ID is greater than 5");
            foreach (Employee emp in over5)
            {
                Console.WriteLine(emp.Fname + " " + emp.Lname);
            }

            Console.ReadLine();

            

        }
    }
}
