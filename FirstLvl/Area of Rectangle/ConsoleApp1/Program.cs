using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа предназначена для высчитывания площади прямоугольникa . \nВведите длину:");
            string long1= Console.ReadLine();
            Console.WriteLine("ВВедите ширину :");
            string wide = Console.ReadLine();
            int result = Int32.Parse(long1) * Int32.Parse(wide);
            Console.WriteLine($"Результат - {result}");
            Console.ReadLine();
        }
    }
}
