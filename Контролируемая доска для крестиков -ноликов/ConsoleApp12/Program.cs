using System;

namespace Контролируемая_доска_для_крестиков__ноликов
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "   ";
            string second = "   ";
            string third = "   ";
            string fourth = "   ";
            string fifth = "   ";
            string sixth = "   ";
            string seventh = "   ";
            string eights = "   ";
            string ninth = "   ";
            Console.WriteLine("Добро пожаловать в крестики-нолики !");
            Console.WriteLine("Ведите содержимое клетки 1:");
            string move1 = Console.ReadLine();
            switch (move1)
            {
                case "0":
                   first = " O ";
                    break;
                case "X":
                   first = " X ";
                    break;
                case " ":
                    first = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 2:");
            string move2 = Console.ReadLine();
            switch (move2)
            {
                case "0":
                   second = " O ";
                    break;
                case "X":
                    second = " X ";
                    break;
                case " ":
                   second = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 3:");
            string move3 = Console.ReadLine();
            switch (move3)
            {
                case "0":
                   third = " O ";
                    break;
                case "X":
                   third = " X ";
                    break;
                case " ":
                   third = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 4:");
            string move4 = Console.ReadLine();
            switch (move4)
            {
                case "0":
                   fourth = " O ";
                    break;
                case "X":
                    fourth = " X ";
                    break;
                case " ":
                    fourth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 5:");
            string move5 = Console.ReadLine();
            switch (move5)
            {
                case "0":
                  fifth= " O ";
                    break;
                case "X":
                    fifth = " X ";
                    break;
                case " ":
                    fifth = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 6:");
            string move6 = Console.ReadLine();
            switch (move6)
            {
                case "0":
                   sixth = " O ";
                    break;
                case "X":
                    sixth = " X ";
                    break;
                case " ":
                   sixth= "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 7:");
            string move7 = Console.ReadLine();
            switch (move7)
            {
                case "0":
                   seventh = " O ";
                    break;
                case "X":
                   seventh = " X ";
                    break;
                case " ":
                    seventh = "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 8:");
            string move8 = Console.ReadLine();
            switch (move8)
            {
                case "0":
                    eights = " O ";
                    break;
                case "X":
                   eights = " X ";
                    break;
                case " ":
                    eights= "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            Console.WriteLine("Ведите содержимое клетки 9:");
            string move9 = Console.ReadLine();
            switch (move9)
            {
                case "0":
                   ninth = " O ";
                    break;
                case "X":
                    ninth = " X ";
                    break;
                case " ":
                    ninth= "   ";
                    break;
                default:
                    Console.WriteLine("Введите правильный ход!");
                    break;





            }
            string second_string = "---+---+---";
            Console.WriteLine($"{first}|{second}|{third}\n{second_string}\n{fourth}|{fifth}|{sixth}\n{second_string}\n{seventh}|{eights}|{ninth}");
            Console.ReadLine();
            Console.ReadLine();
        }
        
    }
}
