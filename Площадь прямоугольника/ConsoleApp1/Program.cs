using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа предназначена для высчитывания площади прямоугольникa . \nВведите длину:");
            string A = Console.ReadLine();
            Console.WriteLine("ВВедите ширину :");
            string B = Console.ReadLine();
            int result = Int32.Parse(A) * Int32.Parse(B);
            Console.WriteLine($"Результат - {result}");
            Console.ReadLine();
        }
    }
}
