using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z2
    {
        public static void solution()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a <= 10) && (a > 5))
            {
                Console.WriteLine("Число больше пяти и меньше десяти");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }

        }
    }
}