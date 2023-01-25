using System;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string action;
            Console.WriteLine("Введите первое число:");
            firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: +, -, /, *");
            action = Console.ReadLine();
            switch (action)
            {
                default:
                    { 
                    Console.WriteLine("Такой операции не существует в данной программе!");
                    Console.WriteLine("Введите любой символ для выхода из программы:");
                    Console.ReadLine();
                    break;
                    }
                case "+":
                    { 
                    Console.WriteLine("Результат сложения:");
                    Console.WriteLine(firstNumber + secondNumber);
                    Console.WriteLine("Введите любой символ для выхода из программы:");
                    Console.ReadLine();
                    break;
                    }
                case "-":
                    {
                        Console.WriteLine("Результат вычитания:");
                        Console.WriteLine(firstNumber - secondNumber);
                        Console.WriteLine("Введите любой символ для выхода из программы:");
                        Console.ReadLine();
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Результат деления:");
                        Console.WriteLine(firstNumber / secondNumber);
                        Console.WriteLine("Введите любой символ для выхода из программы:");
                        Console.ReadLine();
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Результат умножения:");
                        Console.WriteLine(firstNumber * secondNumber);
                        Console.WriteLine("Введите любой символ для выхода из программы:");
                        Console.ReadLine();
                        break;
                    }
            }

        }
    }
}
