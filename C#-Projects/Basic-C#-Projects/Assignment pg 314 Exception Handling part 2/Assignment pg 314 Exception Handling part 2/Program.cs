using System;
//1. Ask the user for their age.

//2. Display the year the user was born.

//3. Exceptions must be handled using “try/catch.”

//4. Display appropriate error messages if the user enters zero or negative numbers.

//5. Display a general message if an exception was caused by anything else.

namespace Assignment_pg_314_Exception_Handling_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yourAge = false;

            while (!yourAge)
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age == 0)
                    {
                        throw new Exceptions.tooYoung();
                    }
                    else if (age < 0)
                    {
                        throw new Exceptions.negative();
                    }
                    else
                    {
                        int now = DateTime.Now.Year;
                        int yearBorn = now - age;
                        Console.WriteLine(yearBorn);
                        Console.ReadLine();
                    }
                }
                catch (Exceptions.negative)
                {
                    Console.WriteLine("You entered a negative number. You mustn't time travel.");
                    yourAge = false;
                }
                catch (Exceptions.tooYoung)
                {
                    Console.WriteLine("Dont be silly, babies can't type... yet.");
                    yourAge = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                    yourAge = false;
                }
            }                   
        }
    }
}
