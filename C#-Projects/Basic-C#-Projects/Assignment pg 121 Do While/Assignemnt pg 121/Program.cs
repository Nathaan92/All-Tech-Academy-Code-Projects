//1.Do a boolean comparison using a while statement.
//2.Do a boolean comparison using a do while statement.

using System;

namespace Assignemnt_pg_121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop");
            Console.WriteLine("Guess my favorite color?");
            string color = Console.ReadLine();
            bool wrongGuess = false;

            while (!wrongGuess)
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("Red is a good color but not my favorite. Try again.");
                        Console.WriteLine("Guess my favorite color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("Green is a good color but not my favorite. Try again.");
                        Console.WriteLine("Guess my favorite color?");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yellow is a good color but not my favorite. Try again.");
                        Console.WriteLine("Guess my favorite color?");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed it! Blue is my fovorite color! That is correct!");
                        wrongGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, the color " + color + " is not my favorite");
                        Console.WriteLine("Guess my favorite color?");
                        color = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Do Wile Loop");
            Console.WriteLine("Guess my favorite color?");
            string dwColor = Console.ReadLine();
            bool badGuess = dwColor == "blue";
            
            do
            {
                switch (dwColor)
                {
                    case "red":
                        Console.WriteLine("Red is a good color but not my favorite. Try again.");
                        dwColor = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("Green is a good color but not my favorite. Try again.");
                        dwColor = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("Yellow is a good color but not my favorite. Try again.");
                        dwColor = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed it! Blue is my fovorite color! That is correct!");
                        badGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, the color " + dwColor + " is not my favorite");
                        dwColor = Console.ReadLine();
                        break;
                }
            }
            while (!badGuess);
            Console.ReadLine();
        }
    }
}
