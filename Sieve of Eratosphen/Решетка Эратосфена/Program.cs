using System;
using System.Collections.Generic;

namespace Решетка_Эратосфена
{
    class Program
    {

        static List<uint> Eratosphen(uint n)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            var numbers = Eratosphen(n);
            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();
        }
    }
}
