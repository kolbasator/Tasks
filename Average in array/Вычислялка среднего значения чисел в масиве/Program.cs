using System;
using System.Linq;
namespace Вычислялка_среднего_значения_чисел_в_масиве
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers:");
            string Value = Console.ReadLine();
            double[] array = new double[Convert.ToInt32(Value)];
            Console.WriteLine("put your numbers:");
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = Convert.ToDouble(Console.ReadLine());
            }
            double average = array.Average();
            Console.WriteLine($"The average of numbers {average}.Thanks for using our program!");
            Console.ReadLine();


        }
    }
}
