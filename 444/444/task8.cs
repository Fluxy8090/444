using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z8
    {
        public static void solution()
        {
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (((a > 0) && (b > 0)) && (a < 10) && (b < 10))
                {
                    Console.WriteLine(a * b);
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы, Введите еще раз");
                }
            }
        }
    }
}