//1) Concatenates three strings.
//2) Converts a string to uppercase.
//3) Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg_125
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOne = "It is tuesday night.";
            string sTwo = "It is 11:34pm.";
            string sThree = "It is dark outside";
            string sFour = sOne + sTwo + sThree;
            string sFive = sThree.ToUpper();//uppercase version

            Console.WriteLine(sOne + sTwo + sThree);
            Console.WriteLine(sFive);

            StringBuilder para = new StringBuilder();
            para.AppendLine("Jack and Jill went up the hill,");
            para.AppendLine("To fetch a pail of water.");
            para.AppendLine("Jakc fell down and broke his crown.");
            para.AppendLine("And Jill came tumbling after.");
            Console.WriteLine(para);

            Console.ReadLine();
        }
    }
}
