using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters_Method
{
    public class Methods
    {
        public static int Maths(int num1, int num2 = 3)
        {
            int result = num1 + 10 + num2;
            return result;
        }
    }
}
