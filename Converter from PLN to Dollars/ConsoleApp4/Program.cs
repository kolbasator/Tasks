using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа для перевода злотых в доллары .Введи кол-во злотых:");
            int PLN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат :" + Math.Round(PLN / 3.67, 2));
            Console.ReadLine();
        }
    }
}
