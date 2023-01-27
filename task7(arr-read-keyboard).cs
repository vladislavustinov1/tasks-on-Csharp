using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int[] arr = new int [5];
            for (int i = 0; i < arr.Length; i++)
            {
                cnt++;
                Console.WriteLine("Введите элемент массива:");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(cnt + "-й элемент массива равен " + arr[i]);
            }
            var str = string.Join(" ", arr);
            Console.WriteLine("Длина массива: " + arr.Length);
            Console.WriteLine("Полученный массив: " + str);
        }
    }
}
