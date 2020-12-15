using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Employee : Person, IQuittable
    {
        public int ID {get; set;}
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }

        public static bool operator==(Employee employee1, Employee employee2)
        {
            bool isTheSame = false;
            if(employee1.ID == employee2.ID)
            {
                isTheSame = true;
            }
            return isTheSame;
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            bool isNotTheSame = false;
            if(employee1.ID != employee2.ID)
            {
                isNotTheSame = true;
            }
            return isNotTheSame;
        }
    }
}
