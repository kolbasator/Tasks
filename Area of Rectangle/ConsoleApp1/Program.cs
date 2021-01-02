using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа предназначена для высчитывания площади прямоугольникa . \nВведите длину:");
            string Long= Console.ReadLine();
            Console.WriteLine("ВВедите ширину :");
            string Wide = Console.ReadLine();
            int Result = Int32.Parse(Long) * Int32.Parse(Wide);
            Console.WriteLine($"Результат - {Result}");
            Console.ReadLine();
        }
    }
}
