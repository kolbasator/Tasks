using System;

namespace Расчитыватель_факториала_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа находит факториал числа.Введите число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            long FactorialOfNumber = Factorial(Number);
            Console.WriteLine(FactorialOfNumber);
            Console.ReadLine();
            Console.ReadLine();

        }
        static long Factorial(int number)
        {
            long LongNumber = Convert.ToInt64(number);
            long NewLongNumber = LongNumber += 1;
            long start = 1;
            for (long i = 1; i < NewLongNumber; i++)
            {
                start *= i;
            }
            long factorial = start;
            return factorial;
        }
    }
}
