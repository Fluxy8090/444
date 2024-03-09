using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z1
    {
        public static void solution()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Число a больше числа b");
            }
            else if (b > a)
            {
                Console.WriteLine("Число b больше числа a");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

        }
    }
}