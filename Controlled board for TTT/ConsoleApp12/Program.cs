using System;

namespace Контролируемая_доска_для_крестиков__ноликов
{
    class Program
    {
        static void Main(string[] args)
        {
            string First = "   ";
            string Second = "   ";
            string Third = "   ";
            string Fourth = "   ";
            string Fifth = "   ";
            string Sixth = "   ";
            string Seventh = "   ";
            string Eights = "   ";
            string Ninth = "   ";
            Console.WriteLine("Добро пожаловать в крестики-нолики !");
            Console.WriteLine("Ведите содержимое клетки 1:");
            string Move1 = Console.ReadLine();
            switch (Move1)
            {
                case "0":
                    First = " O ";
                    break;
                case "X":
                    First = " X ";
                    break;
                case " ":
                    First = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 2:");
            string Move2 = Console.ReadLine();
            switch (Move2)
            {
                case "0":
                    Second = " O ";
                    break;
                case "X":
                    Second = " X ";
                    break;
                case " ":
                    Second = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 3:");
            string Move3 = Console.ReadLine();
            switch (Move3)
            {
                case "0":
                    Third = " O ";
                    break;
                case "X":
                    Third = " X ";
                    break;
                case " ":
                    Third = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 4:");
            string Move4 = Console.ReadLine();
            switch (Move4)
            {
                case "0":
                    Fourth = " O ";
                    break;
                case "X":
                    Fourth = " X ";
                    break;
                case " ":
                    Fourth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 5:");
            string Move5 = Console.ReadLine();
            switch (Move5)
            {
                case "0":
                    Fifth = " O ";
                    break;
                case "X":
                    Fifth = " X ";
                    break;
                case " ":
                    Fifth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 6:");
            string Move6 = Console.ReadLine();
            switch (Move6)
            {
                case "0":
                    Sixth = " O ";
                    break;
                case "X":
                    Sixth = " X ";
                    break;
                case " ":
                    Sixth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 7:");
            string Move7 = Console.ReadLine();
            switch (Move7)
            {
                case "0":
                    Seventh = " O ";
                    break;
                case "X":
                    Seventh = " X ";
                    break;
                case " ":
                    Seventh = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 8:");
            string Move8 = Console.ReadLine();
            switch (Move8)
            {
                case "0":
                    Eights = " O ";
                    break;
                case "X":
                    Eights = " X ";
                    break;
                case " ":
                    Eights = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 9:");
            string Move9 = Console.ReadLine();
            switch (Move9)
            {
                case "0":
                    Ninth = " O ";
                    break;
                case "X":
                    Ninth = " X ";
                    break;
                case " ":
                    Ninth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            string SecondString = "---+---+---";
            Console.WriteLine($"{First}|{Second}|{Third}\n{SecondString}\n{Fourth}|{Fifth}|{Sixth}\n{SecondString}\n{Seventh}|{Eights}|{Ninth}");
            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
