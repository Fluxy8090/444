using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z4
    {
        public static void solution()
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());

            if (a < 100)
            {
                a *= 1.05m;
            }
            else if ((a >= 100) && (a < 200))
            {
                a *= 1.07m;
            }
            else if (a >= 200)
            {
                a *= 1.1m;
            }
            Console.WriteLine(a);
        }

    }
}