using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;
            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = int.Parse(str);
            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = int.Parse(str);
            double result = ( (double) a + b) / 2;
            Console.WriteLine("Среднее арифметическое двух чисел:" + result);
        }
    }
}
