using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

//2. In the Main() method, create an object of data type Number and assign an amount to it.

//3. Print this amount to the console.

namespace Assignment_pg_260_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numeroUno = new Number();
            numeroUno.Amount = 0.1m;
            Console.WriteLine(numeroUno.Amount);
            Console.ReadLine();
        }
    }
}
