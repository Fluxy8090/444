using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4i
{
    internal class z10
    {
        public static void solution()
        {
            String[] array = { "эщкере", "вода", "чипсы", "зубы", "не ругайтесь что все в 1 файле, пожалуйста" };
            String str = Console.ReadLine();
            bool flag = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (str == array[i])
                {
                    Console.WriteLine("Строка найдена!");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Строка не найдена!");
            }
        }
    }
}