using System;

namespace Решение_примера
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double FirstNumber= Convert.ToDouble(Console.ReadLine());
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(Counter(FirstNumber, SecondNumber), 4));
            Console.ReadLine();

        }
        static double Counter(double a,double b)
        {
            double i = a + b;
            return a * b / i;
        }
      
    }
}
