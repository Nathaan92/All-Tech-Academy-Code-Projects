using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n\t Hello on a tab";
            //string fileName = "C:\\Users\\Jesse";
            //string fileName1 = @"C:\Users\Jesse"; //another method for full string escape

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;  //lenght of string

            //name = name.ToUpper();
            //name1 = name.ToLower();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
