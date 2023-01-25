using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_second
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
            double numberFirst, numberSecond;
            string action;
            Console.WriteLine("Введите первое число:");
            numberFirst = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            numberSecond = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию +, -, /, *:");
            action = Console.ReadLine();
            if (action == "+")
            {
                Console.WriteLine("Результат сложения:");
                Console.WriteLine(numberFirst + numberSecond);
            } else if (action == "-")
            {
                Console.WriteLine("Результат вычитания:");
                Console.WriteLine(numberFirst - numberSecond);
            } else if (action == "*")
            {
                Console.WriteLine("Результат умножения");
                Console.WriteLine(numberFirst * numberSecond);
            } else if (action == "/")
            {
                Console.WriteLine("Результат деления:");
                Console.WriteLine(numberFirst / numberSecond);
            }
                Console.WriteLine("Введите любой символ для продолжения");
                Console.ReadLine();
            }
        }
    }
}
