﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

namespace Three_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number? The number you enter will be uused in simple math operations:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum + " + 100 = " + threeMethods.Addition(userNum));

            Console.WriteLine(userNum + " - 1 = " + threeMethods.Subtraction(userNum));

            Console.WriteLine(userNum + " * 10 = " + threeMethods.Multiplication(userNum));

            Console.ReadLine();
        }
    }
}
