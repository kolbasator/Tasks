using System;

namespace Вычислялка_среднего_значения_чисел_в_масиве
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers:");
            string value = Console.ReadLine();
            double[] array= new double[Convert.ToInt32(value)];
            
            Console.WriteLine("put your numbers:");
            for(int j = 0; j < array.Length; j++)
            {
                array[j] = Convert.ToDouble(Console.ReadLine());
            }
            double total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }
            double average = total / array.Length;
            Console.WriteLine($"The average of numbers {average}.Thanks for using our program!");
            Console.ReadLine();


        }
    }
}
