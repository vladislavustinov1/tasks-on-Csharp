using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int cnt = 0;
            Console.Write("Кол-во элементов массива: ");
            int elem = int.Parse(Console.ReadLine());
            int[] arr = new int [elem];
            for (int i = 1; i < arr.Length; i++)
            {
                cnt++;
                Console.WriteLine("Введите элемент массива:");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(cnt + "-й элемент массива равен " + arr[i]);
                if (arr[i] % 2 == 0)
                {
                    res += arr[i];
                }
            }
            for (int i = arr.Length - 1; i > 0; --i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n" + "Сумма четных чисел: " + res);
            var str = string.Join(" ", arr);
            Console.WriteLine("\n" + "Длина массива: " + arr.Length);
            Console.WriteLine("Полученный массив: " + str);
        }
    }
}
