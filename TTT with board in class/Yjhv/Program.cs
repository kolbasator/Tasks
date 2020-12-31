using System;

namespace Доска_для_крестиков_ноликов
{
    class Program
    {


        static void Main(string[] args)
        {
            bool i = true;
            while (i)
            {
                Board.One = " ";
                Board.Two = " ";
                Board.Three = " ";
                Board.Four = " ";
                Board.Five = " ";
                Board.Six = " ";
                Board.Seven = " ";
                Board.Eight = " ";
                Board.Nine = " ";
                Console.WriteLine(" Новая игра -1");
                Console.WriteLine(" Об авторе –2");
                Console.WriteLine(" Выход-3");
                string Move = Console.ReadLine();
                bool i2 = true;

                switch (Move)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("New Game");
                        string WhoseMove = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{WhoseMove} move:");
                        MoveInTheGame(WhoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        WhoseMove = "O";

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
                        string Agree = Console.ReadLine();
                        if (Agree == "Нет")
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
            if (Board.One == "O" && Board.Two == "O" && Board.Three == "O")
            {
                return true;
            }
            else if (Board.Four == "O" && Board.Five == "O" && Board.Six == "O")
            {
                return true;
            }
            else if (Board.Seven == "O" && Board.Eight == "O" && Board.Nine == "O")
            {
                return true;
            }

            else if (Board.One == "O" && Board.Five == "O" && Board.Eight == "O")
            {
                return true;
            }
            else if (Board.Seven == "O" && Board.Five == "O" && Board.Three == "O")
            {
                return true;
            }

            else if (Board.One == "O" && Board.Four == "O" && Board.Seven == "O")
            {
                return true;
            }
            else if (Board.Two == "O" && Board.Five == "O" && Board.Eight == "O")
            {
                return true;
            }
            else if (Board.Three == "O" && Board.Six == "O" && Board.Nine == "O")
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

            if (Board.One == "X" && Board.Two == "X" && Board.Three == "X")
            {
                return true;
            }
            else if (Board.Four == "X" && Board.Five == "X" && Board.Six == "X")
            {
                return true;
            }
            else if (Board.Seven == "X" && Board.Eight == "X" && Board.Nine == "X")
            {
                return true;
            }

            else if (Board.One == "X" && Board.Five == "X" && Board.Eight == "X")
            {
                return true;
            }
            else if (Board.Seven == "X" && Board.Five == "X" && Board.Three == "X")
            {
                return true;
            }

            else if (Board.One == "X" && Board.Four == "X" && Board.Seven == "X")
            {
                return true;
            }
            else if (Board.Two == "X" && Board.Five == "X" && Board.Eight == "X")
            {
                return true;
            }
            else if (Board.Three == "X" && Board.Six == "X" && Board.Nine == "X")
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
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Board.One, Board.Two, Board.Three);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Board.Four, Board.Five, Board.Six);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Board.Seven, Board.Eight, Board.Nine);
        }
        static void MoveInTheGame(string wm)
        {
            bool i = true;
            while (i == true)
            {
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        if (Board.One != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.One = wm;
                        i = false;
                        break;
                    case "2":
                        if (Board.Two != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Two = wm;
                        i = false;
                        break;
                    case "3":
                        if (Board.Three != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Three = wm;
                        i = false;
                        break;
                    case "4":
                        if (Board.Four != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Four = wm;
                        i = false;
                        break;
                    case "5":
                        if (Board.Five != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Five = wm;
                        i = false;
                        break;
                    case "6":
                        if (Board.Six != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Six = wm;
                        i = false;
                        break;
                    case "7":
                        if (Board.Seven != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Seven = wm;
                        i = false;
                        break;
                    case "8":
                        if (Board.Eight != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Eight = wm;
                        i = false;
                        break;
                    case "9":
                        if (Board.Nine != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        Board.Nine = wm;
                        i = false;
                        break;
                    default:
                        Console.WriteLine("Illegal move! Try again.");
                        continue;

                }
            }
        }
    }
    
}
