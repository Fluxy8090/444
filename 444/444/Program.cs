﻿using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using zada4i;
class MainTask()
{
    static public void Main(string[] args)
    {
        Console.WriteLine("Первое задание, введите два числа");
        z1.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Второе задание, введите число от 5 до 10 включительно");
        z2.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Третье задание, введите либо 5 либо 10");
        z3.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Четвертое задание, введите любую сумму вклада в банк для получения процентной ставки");
        z4.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Пятое задание, введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        z5.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Шестое задание, введите два числа, первое - сумма вклада, второе - количество месяцев");
        z6.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Седьмое задание, сейчас выведется таблица умножения");
        z7.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Восьмое задание, введите два числа от 0 до 10");
        z8.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Девятое задание,будет задан массив целых чисел от 1 до 20 откуда будут выведены только нечетные числа этого массива");
        z9.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Десятое задание, будет задан массив строк, введите свою строку, будет проверено ее содержимое в изначальном массиве");
        z10.solution();
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Одиннадцатое задание, будет задан массив чисел, и найдена сумма чисел этого массива и среднее арифметическое чисел этого массива");
        z11.solution();
    }
}