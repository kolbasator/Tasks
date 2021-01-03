using System;

namespace Решение_примера
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double firstNumber= Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(Counter(firstNumber, secondNumber), 4));
            Console.ReadLine();

        }
        static double Counter(double a,double b)
        {
            double i = a + b;
            return a * b / i;
        }
      
    }
}
