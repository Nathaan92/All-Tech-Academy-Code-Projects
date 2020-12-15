using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read(); //Prevents console window from closing until you've closed it yourself
        }
    }
}
