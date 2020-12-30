using System;

namespace Расчитыватель_факториала_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа находит факториал числа.Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorial = Factorial(number);
            Console.WriteLine(factorial);
            Console.ReadLine();
            Console.ReadLine();

        }
        static long Factorial(int number)
        {
            long long_number = Convert.ToInt64(number);
            long new_long_number = long_number += 1;
            long start = 1;
            for (long i = 1; i < new_long_number; i++)
            {
                 start *= i;
            }
            long factorial = start;
            return factorial;
        }
    }
}
