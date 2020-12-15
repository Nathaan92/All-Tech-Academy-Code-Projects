using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Exception_Handling
{
    class Program
    {
//        IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1. Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
//2. Run that code, entering in non-zero numbers as the user.Look at the displayed results.
//3. Run that code, entering in zero as the number to divide by.Note any error messages you get.
//4. Run that code, entering in a string as the number to divide by.Note any error messages you get.
//5. Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.


        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine("Integers to be used in this assigment 1, 2, 3, 4, 5, 6, 7, 8, 9");
                Console.WriteLine("Please provide a number to be divided by the integers above : ");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int answer = number / userNum;
                    Console.WriteLine(answer);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("The program has concluded try/catch block.");
            Console.WriteLine("It will now continue the program.");
            Console.ReadLine();
        }
    }
}
