using System;

namespace Программа_которая_распечатывает_числа_задом_наперед
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[21];
            Console.WriteLine("Эта программа распечатает 20 чисел в обратном порядке.");
            Console.WriteLine("Введите 20 чисел:");
            for (i = 1; i <= 20; i++)
            {

                Console.WriteLine($"Введите {i} число:");
                arr[i] = Convert.ToInt32((Console.ReadLine()));
            }
            for (i = 20; i >= 1; i--)
                Console.WriteLine(arr[i]);
            Console.ReadLine();
        }


    }
}
