//1.Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
//2. In the Main() method of the console app, instantiate the class.
//3.Call the method in the class, passing in two numbers.
//4. Call the method in the class, specifying the parameters by name

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Class
{
    public class method
    {
        public static void voidMethod(int p1, int p2)
        {
            int answer1 = p1 + 100;
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
