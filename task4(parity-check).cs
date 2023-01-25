using System;

namespace lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите ваше число:");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число " + number + " чётное");
            }
            else
            {
                Console.WriteLine("Число " + number + " нечётное");
            }
        }
    }
}
