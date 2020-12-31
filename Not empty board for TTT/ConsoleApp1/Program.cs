using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string First = " X ";
            string Second = "   ";
            string Third = " O ";
            string Fourth = " X ";
            string Fifth = " O ";
            string Sixth = " O ";
            string Seventh = "   ";
            string Eights = "   ";
            string Ninth = "   ";
            Console.WriteLine("Hello World!");
            string first_string1 = $"{First}|{Second}|{Third}";
            string first_string2 = $"{Fourth}|{Fifth}|{Sixth}";
            string first_string3 = $"{Seventh}|{Eights}|{Ninth}";
            string second_string = "---+---+---";
            Console.WriteLine($"{first_string1}\n{second_string}\n{first_string2}\n{second_string}\n{first_string3}");
            Console.ReadLine();
        }
    }
}
