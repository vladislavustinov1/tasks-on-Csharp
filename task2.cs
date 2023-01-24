using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b, c;
            Console.WriteLine("Введите первое число:");
            str = Console.ReadLine();
            a = int.Parse(str);
            Console.WriteLine("Введите второе число:");
            str = Console.ReadLine();
            b = int.Parse(str);
            Console.WriteLine("Введите третье число:");
            str = Console.ReadLine();
            c = int.Parse(str);
            int result1 = a + b + c;
            int result2 = a * b * c;
            Console.WriteLine("Результат сложения:" + result1);
            Console.WriteLine("Результат умножения:" + result2);
        }
    }
}
