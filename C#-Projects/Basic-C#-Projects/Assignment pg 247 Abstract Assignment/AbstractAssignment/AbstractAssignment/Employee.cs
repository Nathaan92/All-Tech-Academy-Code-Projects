using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee<T> : Person, IQuittable //<T> A generic type parameter
        {
            public Employee()
            {
                Things = new List<T>();
            }
            public List<T> Things {get; set;}
            public int ID {get; set;}
            public override void SayName()
            {
                Console.WriteLine("Name: " + firstName + " " + lastName);
            }

            public void Quit()
            {
                Console.WriteLine("I quit!");
            }

            public static bool operator==(Employee<T> employee1, Employee<T> employee3)
            {
                bool isTheSame = false;
                if(employee1.ID == employee3.ID)
                {
                    isTheSame = true;
                }
                return isTheSame;
            }
            public static bool operator!=(Employee<T> employee1, Employee<T> employee3)
            {
                bool isNotTheSame = false;
                if(employee1.ID != employee3.ID)
                {
                    isNotTheSame = true;
                }
                return isNotTheSame;
       }
    }
}
