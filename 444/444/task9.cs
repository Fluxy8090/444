using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z9
    {
        public static void solution()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

        }
    }
}