using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа для перевода злотых в доллары .Введи кол-во злотых:");
            string pln = Console.ReadLine();
            int plnInt = Convert.ToInt32(pln);
            double dollars = plnInt / 3.67;
            Console.WriteLine("Результат :");
            Console.WriteLine(Math.Round(dollars, 2));
            Console.ReadLine();
        }
    }
}
