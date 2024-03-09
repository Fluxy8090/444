using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z7
    {
        public static void solution()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j);
                }
                Console.WriteLine("****************");
            }
        }
    }
}