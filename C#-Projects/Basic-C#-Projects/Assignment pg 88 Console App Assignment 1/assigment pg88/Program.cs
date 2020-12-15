//1.Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
//2.Takes an input from the user, adds 25 to it, then prints the result to the console.
//3. Takes an input from the user, divides it by 12.5, then prints the result to the console.
//4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
//5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).

using System;

namespace assigment_pg88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number: ");
            string multi = Console.ReadLine();
            int a = System.Convert.ToInt32(multi);
            int mRes = 50 * a;
            Console.WriteLine("50 * " + a + " = " + mRes);
            

            Console.WriteLine("Pick a Number: ");
            string add = Console.ReadLine();
            int e = System.Convert.ToInt32(add);
            int aRes = 25 + e;
            Console.WriteLine("25 + " + e + " = " + aRes);
            

            Console.WriteLine("Pick a Number: ");
            string div = Console.ReadLine();
            Double i = Double.Parse(div);
            Double dRes = i / 12.50;
            Console.WriteLine(i  + " / 12.50 = "  + " = " + dRes);
            

            Console.WriteLine("Pick a Number: ");
            string greatThan = Console.ReadLine();
            int o = System.Convert.ToInt32(greatThan);
            bool trueOrFalse = o > 50;
            string y = trueOrFalse.ToString();
            Console.WriteLine("Is " + o + " greater than 50 ? " + y);
            
      

            Console.WriteLine("Pick a Number: ");
            string divid = Console.ReadLine();
            float u = float.Parse(divid);
            float dRess = u % 7.00f;
            Console.WriteLine(u + " / 7 = " + dRess);
            Console.ReadLine();




        }
    }
}
