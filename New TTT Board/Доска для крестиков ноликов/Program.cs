using System;

namespace Доска_для_крестиков_ноликов
{
    class Program
    {
        static string[] Pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        static void Main(string[] args)
        {
            string WhoseMove= "X";
            Console.WriteLine("Welcome to tic-tac-toe!");
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "O";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "X";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "O";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "X";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "O";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "X";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "O";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "X";
            DrawBoard();
            Console.WriteLine($"{WhoseMove} move:");
            Move(Pos, WhoseMove);
            WhoseMove = "O";
            Console.WriteLine("Game Over!");
            Console.ReadLine();
            Console.ReadLine();
        }
        static void DrawBoard() 
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[1], Pos[2], Pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[4], Pos[5], Pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
        }
        static void Move(string[] board,string wm)
        {
            bool i = true;
            while (i == true)
            {
                int move = Convert.ToInt32(Console.ReadLine());
                switch (move)
                {
                    case 1:
                        if(board[1]!=" ")
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
