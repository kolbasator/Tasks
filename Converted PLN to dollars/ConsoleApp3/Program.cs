using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int PLN = 100;
            double Dollars=PLN/ 3.67;
            Console.WriteLine(Math.Round(Dollars,2));
            Console.ReadLine();
        }
    }
}
