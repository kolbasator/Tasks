using System;

namespace Решение_примера
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a = Console.ReadLine();
            string b= Console.ReadLine();
            double a_number = Convert.ToDouble(a);
            double b_number = Convert.ToDouble(b);
            double result = Math.Round(Counter(a_number, b_number),4);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        static double Counter(double a,double b)
        {
            double i = a + b;
            return a * b / i;
        }
      
    }
}
