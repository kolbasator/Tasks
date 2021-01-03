using System;

namespace Доска_для_крестиков_ноликов
{
    class Program
    {
        /// <summary>
        /// Board is pos array
        /// </summary>
        static string[] Pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        static void Main(string[] args)
        {
            bool i = true;
            while (i == true)
            {
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

                        string whoseMove = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Move(Pos, whoseMove);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";

                        Console.WriteLine("Game Over!");
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.ReadLine();
                        continue;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Имя-Кирилл\nФамилия-Чеботарев\nВозраст-12 лет\nПитомцы-Кошка Мусяка\nЛюбимое дело -программирование и спорт \nЯзык программирования-С#");
                        Console.ReadLine();
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
        /// <summary>
        /// Checks if someone won or not
        /// </summary>
        /// <returns>  Someone won or not</returns>
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
        /// <summary>
        /// Method for checking whether the Circle won or not
        /// </summary>
        /// <returns> Has the circle won or not</returns>
        static bool OWin()
        {
            if (Pos[1] == "O" && Pos[2] == "O" && Pos[3] == "O")
            {
                return true;
            }
            else if (Pos[4] == "O" && Pos[5] == "O" && Pos[6] == "O")
            {
                return true;
            }
            else if (Pos[7] == "O" && Pos[8] == "O" && Pos[9] == "O")
            {
                return true;
            }

            else if (Pos[1] == "O" && Pos[5] == "O" && Pos[9] == "O")
            {
                return true;
            }
            else if (Pos[7] == "O" && Pos[5] == "O" && Pos[3] == "O")
            {
                return true;
            }

            else if (Pos[1] == "O" && Pos[4] == "O" && Pos[7] == "O")
            {
                return true;
            }
            else if (Pos[2] == "O" && Pos[5] == "O" && Pos[8] == "O")
            {
                return true;
            }
            else if (Pos[3] == "O" && Pos[6] == "O" && Pos[9] == "O")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Method for checking whether the Cross won or not
        /// </summary>
        /// <returns> Has the cross won or not</returns>
        static bool XWin()
        {

            if (Pos[1] == "X" && Pos[2] == "X" && Pos[3] == "X")
            {
                return true;
            }
            else if (Pos[4] == "X" && Pos[5] == "X" && Pos[6] == "X")
            {
                return true;
            }
            else if (Pos[7] == "X" && Pos[8] == "X" && Pos[9] == "X")
            {
                return true;
            }

            else if (Pos[1] == "X" && Pos[5] == "X" && Pos[9] == "X")
            {
                return true;
            }
            else if (Pos[7] == "X" && Pos[5] == "X" && Pos[3] == "X")
            {
                return true;
            }

            else if (Pos[1] == "X" && Pos[4] == "X" && Pos[7] == "X")
            {
                return true;
            }
            else if (Pos[2] == "X" && Pos[5] == "X" && Pos[8] == "X")
            {
                return true;
            }
            else if (Pos[3] == "X" && Pos[6] == "X" && Pos[9] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  Method for drawing a tic-tac-toe board
        /// </summary>
        static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[1], Pos[2], Pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[4], Pos[5], Pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
        }
        /// <param name="wm">Who are walks now</param>
        /// <param name="board">Tic-Tac-Toe board</param>
        ///<summary>
        /// Method for the move in the game
        ///</summary>
        static void Move(string[] board, string wm)
        {
            bool i = true;
            while (i == true)
            {
                int move = Convert.ToInt32(Console.ReadLine());
                switch (move)
                {
                    case 1:
                        if (board[1] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[1] = wm;
                        i = false;
                        break;
                    case 2:
                        if (board[2] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[2] = wm;
                        i = false;
                        break;
                    case 3:
                        if (board[3] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[3] = wm;
                        i = false;
                        break;
                    case 4:
                        if (board[4] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[4] = wm;
                        i = false;
                        break;
                    case 5:
                        if (board[5] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[5] = wm;
                        i = false;
                        break;
                    case 6:
                        if (board[6] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[6] = wm;
                        i = false;
                        break;
                    case 7:
                        if (board[7] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[7] = wm;
                        i = false;
                        break;
                    case 8:
                        if (board[8] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[8] = wm;
                        i = false;
                        break;
                    case 9:
                        if (board[9] != " ")
                        {
                            Console.WriteLine("Illegal move! Try again.");
                            continue;
                        }
                        board[9] = wm;
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
