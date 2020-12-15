using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg_310_Additional_Features
{
    public class Person
    {
        public string fullName { get; set; }
        public string favColor { get; set; }

        public Person(string me, string color)
        {
            fullName = me;
            favColor = color;
            Console.WriteLine("You are now known as {0} and your favorite color is {1}!", fullName, favColor);
        }
        
        public Person(string color) : this("John Doe", color)
        {

        }

    }
}
