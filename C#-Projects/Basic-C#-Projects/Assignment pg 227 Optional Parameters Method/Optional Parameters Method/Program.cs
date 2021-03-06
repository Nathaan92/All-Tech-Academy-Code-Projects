﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.Have the method do a math operation and return an integer result.

//2. In the Main() method of the console app, instantiate the class.

//3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.

namespace Optional_Parameters_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods maths = new Methods();

            Console.WriteLine("Please enter a number: ");
            string userNum1 = Console.ReadLine();
            
            
            Console.WriteLine("Please enter a second number (This is not nessesary but encouraged) : ");
            string userNum2 = Console.ReadLine();

            int num2;
            if(!int.TryParse(userNum2, out num2))
            {
                int num1 = Convert.ToInt32(userNum1);
                Console.WriteLine("You have entered one number. Your Answer is : " + Methods.Maths(num1));
            }

            else
            {
                int num1 = Convert.ToInt32(userNum1);
                num2 = Convert.ToInt32(userNum2);
                Console.WriteLine("You have entered two numbers. Your Answer is : " + Methods.Maths(num1, num2));
            }

            Console.ReadLine();
        }
    }
}
