using System;

namespace Возводилка_в_степень
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа возводит указанное число в указанную степень.");
            Console.WriteLine("Введите число:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите степень:");
            string b = Console.ReadLine();
            Console.WriteLine("Результат:");
            double a_number = Convert.ToDouble(a);
            double b_number = Convert.ToDouble(b);
            double result = Math.Pow(a_number, b_number);
            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
