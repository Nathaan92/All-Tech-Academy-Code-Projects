using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.A one - dimensional array of strings.
            //2.Ask the user to input some text.
            //3.A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
            //4.Then create a loop that prints off each string in the array on a separate line.
            //5.Save and execute your code.

            string[] originalArray = new string[] { "name can Jump!", "name can Run!", "name can Climb!", "name can Swim!", "name cannot Fly!" };
            Console.WriteLine("Console App Assigment");
            Console.WriteLine("Array Assignemnt");
            Console.WriteLine("Please input your name : ");
            string newName = Console.ReadLine();

            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = originalArray[i].Replace("name", newName);
            }
            foreach (string eStr in originalArray)
            {
                Console.WriteLine(eStr);
            }

            //1.An infinite loop.
            //2.Save your code.
            //3.Fix the infinite loop so that it will execute properly.
            //4.Save and execute your code.

            Console.WriteLine("Infinity Assignemnt");
            int counter = 1;
            Console.WriteLine("To infinity and...");
            while (true)
            {
                Console.WriteLine("Beyond!");
                counter += 1;

                if (counter == 10)
                {
                    break;
                }
            }

            //1.A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            //2.Save and execute your code.
            //3.A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            //4.Save and execute your code.

            Console.WriteLine("Comparision Assignemnt <");
            for (int countDown = 10; 0 < countDown; countDown--)
            {
                Console.WriteLine("T minus : " + countDown);

            }
            Console.WriteLine("TakeOff!!");

            Console.WriteLine("Comparision Assignemnt <=");
            for (int countDown = 10; 0 <= countDown; countDown--)
            {
                Console.WriteLine("T minus : " + countDown);

            }
            Console.WriteLine("TakeOff!!");

            //1.A list of strings where each item in the list is unique.
            //2.Ask the user to input text to search for in the list.
            //3.A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            //4.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //5.Add code to the loop that stops it from executing once a match has been found.
            //6.Save and execute your code


            Console.WriteLine("Search Assignment");

            List<string> numbers = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            Console.WriteLine("Please write out a number one - ten to see its index location : ");
            string searchNumber = Console.ReadLine();

            int j;            
            for (j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == searchNumber)
                {
                    Console.WriteLine("The number you selected is in index location : " + j);
                    break;
                }
            
            }
            if (j > 9)
                {
                Console.WriteLine("The number you have selected is not stored");                
                }

            //1.A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            //2.Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
            //3.Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
            //4.Save and execute your code.

            Console.WriteLine("Identical Assignment");

            List<string> letters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "c", "j" };
            Console.WriteLine("Please enter a letter a - j to see its index location : ");
            string searchLetter = Console.ReadLine();

            int k;
            for (k = 0; k < letters.Count; k++)
            {
                if (letters[k] == searchLetter)
                {
                    Console.WriteLine("The letter(s) you selected is in index location : " + k);
                }

            }
            if (k > 9)
            {
                Console.WriteLine("The letter you have selected is not stored");
            }

            Console.WriteLine("Identical Issue Assignment");

            //1.Create a list of strings that has at least two identical strings in the list.
            //2.Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            //3.Save and execute your code.

            List<string> alphabets = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "c", "j" };
            List<string> alphabetsBravo = new List<string>();

            foreach (string alphabet in alphabets)
                
                if (alphabetsBravo.Contains(alphabet))
                {
                    Console.WriteLine(alphabet + " has already appeared in the list");
                }
                else
                {
                    Console.WriteLine(alphabet + " has not appeared in the list yet.");
                    alphabetsBravo.Add(alphabet);
                }


            Console.ReadLine();
        }
    }
}
