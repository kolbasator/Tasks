using System;

namespace Возводилка_в_степень
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа возводит указанное число в указанную степень.");
            Console.WriteLine("Введите число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат:");
            double result = Math.Pow(a, b);
            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
