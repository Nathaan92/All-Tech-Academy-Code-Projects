//1.The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
//2. The user must then be prompted for the package weight.
//3. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
//4. The user must then be prompted for the package width.
//5. Then the package height.
//6. Then the package length.
//7. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
//8. Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
//9. The result of that calculation is the quote.
//10. Display the quote to the user as a dollar amount.

using System;
using System.Globalization;


namespace Assignment_pg_117
{
    class Program
    {
        static void Main(string[] args)
        {
            string error1 = ("Package too heavy to be shipped via Package express. Have a good day.");
            string error2 = ("Package too big to be shipped via Package express.");

            Console.WriteLine("Welcome to Package Express");
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine(error1);
                Console.ReadLine();
            }

            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (height + width + length > 50) 
            {
                Console.WriteLine(error2);
                Console.ReadLine();
            }

            int total = (((height * width * length) * weight) / 100);
            string aTotal = (total.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Your estimated total for shipping this package is : " + aTotal);
            Console.WriteLine("Thank you");
            Console.ReadLine();


        }
    }
}
