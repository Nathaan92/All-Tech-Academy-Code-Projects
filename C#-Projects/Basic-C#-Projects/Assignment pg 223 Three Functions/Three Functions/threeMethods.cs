using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Functions
{
    public class threeMethods
    {
        public static int Addition(int userNum)
        {
            int add = userNum + 100;
            return add;
        }
        
        public static int Subtraction(int userNum)
        {
            int minus = userNum - 1;
            return minus;
        }
        
        public static int Multiplication(int userNum)
        {
            int multi = userNum * 10;
            return multi;
        }
    }
}
