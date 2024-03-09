using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z6
    {
        public static void solution()
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                a *= 1.07m;
            }

            Console.WriteLine("Конечная сумма вклада составила:");
            Console.WriteLine(a);
        }
    }
}