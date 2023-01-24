using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a;
            double dollars = 69.45;
            Console.WriteLine("Введите, сколько рублей Вы хотите перевести в доллары:");
            str = Console.ReadLine();
            a = int.Parse(str);
            double result = Math.Round(a / dollars);
            Console.WriteLine("Долларов в рублях:" + result);
        }
    }
}
