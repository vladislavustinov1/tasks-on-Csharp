using System;

namespace task6
{
    class task6
    {
        static void Main(string[] args)
        {
            uint odd, even;
            odd = 0;
            even = 0;
            int evenSum = 0;
            int oddSum = 0;
            int value = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            while (value <= limit)
            {
                if (value % 2 == 0)
                {
                    even++;
                    evenSum += value;
                } else
                {
                    odd++;
                    oddSum += value;
                }
                value++;

            }
            Console.WriteLine("Кол-во нечётных: " + odd);
            Console.WriteLine("Кол-во чётных: " + even);
            Console.WriteLine("Сумма нечётных: " + oddSum);
            Console.WriteLine("Сумма чётных: " + evenSum);
        }
    }
}
