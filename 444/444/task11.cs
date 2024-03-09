using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z11
    {
        public static void solution()
        {
            int[] array = new int[10];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Сумма элементов массива = " + sum);
            Console.WriteLine("Среднее арифметическое массива = " + sum / array.Length);
        }
    }
}