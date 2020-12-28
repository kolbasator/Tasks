using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа округляет числа .Введите число:");
            string number = Console.ReadLine();
            double number_int = Convert.ToDouble(number);
            double result =Math.Round(number_int);
            Console.WriteLine($"Результат-{result}");
            Console.ReadLine();
        }
    }
}
