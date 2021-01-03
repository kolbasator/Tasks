using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = " X ";
            string second = "   ";
            string third = " O ";
            string fourth = " X ";
            string fifth = " O ";
            string sixth = " O ";
            string seventh = "   ";
            string eights = "   ";
            string ninth = "   ";
            Console.WriteLine("Hello World!");
            string firstString1 = $"{first}|{second}|{third}";
            string firstString2 = $"{fourth}|{fifth}|{sixth}";
            string firstString3 = $"{seventh}|{eights}|{ninth}";
            string secondString = "---+---+---";
            Console.WriteLine($"{firstString1}\n{secondString}\n{firstString2 }\n{secondString}\n{firstString3}");
            Console.ReadLine();
        }
    }
}
