using System;

namespace Треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int i;
            int j;
            int k;
            Console.WriteLine("Эта программа нарисует вам треугольник с указанной вами высотой.");
            Console.Write("Введите высоту : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
