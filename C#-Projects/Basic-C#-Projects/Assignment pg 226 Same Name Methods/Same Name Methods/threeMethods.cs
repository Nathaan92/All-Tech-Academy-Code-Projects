using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Name_Methods
{
    public class threeMethods
    {
        public static int Maths(int Num)
        {
            int result = Num + 100;
            return result;
        }

        public static decimal Maths(decimal Num)
        {
            int result = (int)(Num * 100);
            return result;
        }

        public static int Maths(string Num)
        {
            int NumConv = Convert.ToInt32(Num);
            int result = (NumConv / 5);
            return result;
        }
    }
}
