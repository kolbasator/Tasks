using System;

namespace Расчитыватель_факториала_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа находит факториал числа.Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            long factorialOfNumber = Factorial(number);
            Console.WriteLine(factorialOfNumber);
            Console.ReadLine();
            Console.ReadLine();

        }
        static long Factorial(int number)
        {
            long longNumber = Convert.ToInt64(number);
            long newLongNumber = longNumber += 1;
            long start = 1;
            for (long i = 1; i < newLongNumber; i++)
            {
                start *= i;
            }
            long factorial = start;
            return factorial;
        }
    }
}
