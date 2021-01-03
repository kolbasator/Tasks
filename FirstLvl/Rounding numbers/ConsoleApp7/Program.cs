using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа округляет числа .Введите число:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат-{Math.Round(number)}");
            Console.ReadLine();
        }
    }
}
