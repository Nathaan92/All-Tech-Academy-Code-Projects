using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_pg_169
{
    public class methods
    {
        public static void Maths(int convUsernum1, out int answer1)
        {
            answer1 = convUsernum1 / 2;
        }
        public static void Maths(string usernum2, out int answer2)
        {
            int convUsernum2 = Convert.ToInt32(usernum2);
            answer2 = convUsernum2 + 100;
        }
    }
}
