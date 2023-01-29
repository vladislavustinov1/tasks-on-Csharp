using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_3
{
    class task8
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int cnt1 = 0;
            Console.Write("Заполните переменную X: ");
            int one = int.Parse(Console.ReadLine());
            Console.Write("Заполните переменную Y: ");
            int two = int.Parse(Console.ReadLine());
            int[,] arr = new int[one, two];
            Console.WriteLine("Длина X = " + arr.GetLength(0));
            Console.WriteLine("Длина Y = " + arr.GetLength(1));
            Random random = new Random();
            for (int y = 0; y < arr.GetLength(0); y++)
            {
                for (int x = 0; x < arr.GetLength(1); x++)
                {
                    //Console.WriteLine("X: " + y + " " + "Y: " + x);
                    //arr[y, x] = int.Parse(Console.ReadLine());
                    arr[y, x] = random.Next(100);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Сумма чётных чисел 2D массива: ");
            for (int a = 0; a < arr.GetLength(0); a++)
            {
                for (int b = 0; b < arr.GetLength(1); b++)
                {
                    if (arr[a, b] % 2 == 0)
                    {
                        cnt += arr[a, b];
                    } else
                    {
                        cnt1 += arr[a, b];
                    }
                }
            }
            Console.Write(cnt + "\n");
            Console.Write("Сумма нечётных чисел 2D массива: ");
            Console.Write(cnt1);
            Console.ReadLine();
        }
    }
}
