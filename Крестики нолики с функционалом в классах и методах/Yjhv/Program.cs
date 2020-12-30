using System;

namespace Доска_для_крестиков_ноликов
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            bool i = true;
            while (i == true)
            {
                Board.one = " ";
                Board.two = " ";
                Board.three = " ";
                Board.four = " ";
                Board.five = " ";
                Board.six = " ";
                Board.seven = " ";
                Board.eight = " ";
                Board.nine = " ";
                Console.WriteLine(" Новая игра -1");
                Console.WriteLine(" Об авторе –2");
                Console.WriteLine(" Выход-3");
                string move = Console.ReadLine();
                bool i2 = true;
               
                    switch (move)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("New Game");
                            string whose_move = "X";
                            Console.WriteLine("Welcome to tic-tac-toe!");
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move( whose_move);
                            i2 = Win();
                           if (i2 == false)
                           {
                            continue;
                           }
                            whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move( whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move( whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move( whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";

                            Console.WriteLine("Game Over!");
                            Console.ReadLine();
                            Console.ReadLine();
                            Console.ReadLine();
                            continue;
                        case "2":
                            InfoAboutMe();
                            continue;
                        case "3":
                            Console.WriteLine("Вы уверены ? Да/Нет");
                            string agree = Console.ReadLine();
                            if (agree == "Нет")
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                i = false;
                            }
                            break;

                    }
                
               
            }
           
        }
        static void InfoAboutMe()
        {
            Console.Clear();
            Console.WriteLine("Имя-Кирилл\nФамилия-Чеботарев\nВозраст-12 лет\nПитомцы-Кошка Мусяка\nЛюбимое дело -программирование и спорт \nЯзык программирования-С#");
            Console.ReadLine();
        }
        static bool Win()
        {
            bool i = true;
            bool x = XWin();
            bool o = OWin();
            if (x == true)
            {
                Console.WriteLine(" X won!");
                i = false;
            }
            else if (o == true)
            {
                Console.WriteLine(" O Won");
                i = false;
            }
            return i;
        }
        
        static bool OWin() 
        {
            if (Board.one == "O" && Board.two == "O" && Board.three == "O")
            {
                return true;
            }
            else if (Board.four == "O" && Board.five == "O" && Board.six == "O")
            {
                return true;
            }
            else if (Board.seven == "O" && Board.eight == "O" && Board.nine == "O")
            {
                return true;
            }

            else if (Board.one == "O" && Board.five == "O" && Board.eight == "O")
            {
                return true;
            }
            else if (Board.seven == "O" && Board.five == "O" && Board.three == "O")
            {
                return true;
            }

            else if (Board.one == "O" && Board.four == "O" && Board.seven == "O")
            {
                return true;
            }
            else if (Board.two == "O" && Board.five == "O" && Board.eight == "O")
            {
                return true;
            }
            else if (Board.three == "O" && Board.six == "O" && Board.nine == "O")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool XWin()
        {

            if (Board.one == "X" && Board.two == "X" && Board.three == "X")
            {
                return true;
            }
            else if (Board.four == "X" && Board.five == "X" && Board.six == "X")
            {
                return true;
            }
            else if (Board.seven == "X" && Board.eight == "X" && Board.nine== "X")
            {
                return true;
            }

            else if (Board.one == "X" && Board.five == "X" && Board.eight == "X")
            {
                return true;
            }
            else if (Board.seven == "X" && Board.five == "X" && Board.three== "X")
            {
                return true;
            }

            else if (Board.one == "X" && Board.four == "X" && Board.seven == "X")
            {
                return true;
            }
            else if (Board.two== "X" && Board.five == "X" && Board.eight == "X")
            {
                return true;
            }
            else if (Board.three == "X" &&Board.six == "X" && Board.nine == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ",Board.one, Board.two, Board.three);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Board.four, Board.five, Board.six);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Board.seven, Board.eight, Board.nine);
        }
        static void Move(string wm)
        {
            bool i = true;
            while (i == true)
            {
                string move =Console.ReadLine();
                switch (move)
                {
                    case "1":
                        if (Board.one != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.one = wm;
                        i = false;
                        break;
                    case "2":
                        if (Board.two != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.two = wm;
                        i = false;
                        break;
                    case "3":
                        if (Board.three != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.three = wm;
                        i = false;
                        break;
                    case "4":
                        if (Board.four != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.four = wm;
                        i = false;
                        break;
                    case "5":
                        if (Board.five != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.five = wm;
                        i = false;
                        break;
                    case "6":
                        if (Board.six != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.six = wm;
                        i = false;
                        break;
                    case "7":
                        if (Board.seven != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.seven = wm;
                        i = false;
                        break;
                    case "8":
                        if (Board.eight != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.eight = wm;
                        i = false;
                        break;
                    case "9":
                        if (Board.nine != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.nine = wm;
                        i = false;
                        break;
                    default:
                        Console.WriteLine("Illegal move! Try again.");
                        continue;

                }
            }
        }
    }
 public static class Board
    {
        public  static string one = " ";
        public static string two = " ";
        public static string three = " ";
        public static string four = " ";
        public static string five = " ";
        public static string six = " ";
        public static string seven = " ";
        public static string eight = " ";
        public static string nine = " ";
        

    }
}
