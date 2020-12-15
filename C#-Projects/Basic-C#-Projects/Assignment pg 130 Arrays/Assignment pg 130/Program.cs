//1.Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
//2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
//3. Add in a message that displays when the user selects an index that doesn’t exist.
//4. Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.

using System;
using System.Collections.Generic;

namespace Assignment_pg_130
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Integer Array");
            int[] numArray = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            Console.WriteLine("Please select an index location from the array. Postions 1-20: ");
            int selectIndex = Convert.ToInt32(Console.ReadLine());
            int adjustedIndex = selectIndex - 1;
            if (adjustedIndex <= 19)
            {
                Console.WriteLine(numArray[selectIndex]);
            }
            else
            {
                Console.WriteLine("That index postion does not exist.");
            }


            Console.WriteLine("String Array");
            string[] stringArray = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"};
            Console.WriteLine("Please select an index location from the array. Postions 1-10");
            int selectIndex1= Convert.ToInt32(Console.ReadLine());
            int adjustedIndex1 = selectIndex1 - 1;
            if (adjustedIndex1 <= 9)
            {
                Console.WriteLine(stringArray[selectIndex1]);
            }
            else
            {
                Console.WriteLine("That index postion does not exist.");
            }

            Console.WriteLine("String List");
            List<string> stringList = new List<string>();
            stringList.Add("One");
            stringList.Add("Two");
            stringList.Add("Thee");
            stringList.Add("Four");
            stringList.Add("Five");
            stringList.Add("Six");
            stringList.Add("Seven");
            stringList.Add("Eight");
            stringList.Add("Nine");
            stringList.Add("Ten");

            Console.WriteLine("Please select an index location from the array. Postions 1-10");
            int selectIndex2 = Convert.ToInt32(Console.ReadLine());
            int adjustedIndex2 = selectIndex2 - 1;
            if (adjustedIndex2 <= 9)
            {
                Console.WriteLine(stringList[selectIndex2]);
            }
            else
            {
                Console.WriteLine("That index position does not exist.");
            }
            Console.ReadLine();

        }
    }
}
