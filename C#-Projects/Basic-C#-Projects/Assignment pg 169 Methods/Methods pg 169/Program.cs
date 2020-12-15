using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.

namespace Methods_pg_169
{
    static class Program
    {
        static void Main(string[] args)
        {
            methods Maths = new methods();
            Console.WriteLine("Please enter a number to be divided by two: ");
            int convUsernum1 = Convert.ToInt32(Console.ReadLine());
            methods.Maths(convUsernum1, out int answer1);
            Console.WriteLine(convUsernum1 + " / 2 : " + answer1);

            Console.WriteLine("Please enter a number to be added to 100 : ");
            string usernum2 = Console.ReadLine();
            methods.Maths(usernum2, out int answer2);
            Console.WriteLine(usernum2 + " + 100 : " + answer2);
            Console.ReadLine();







        }
    }
}
