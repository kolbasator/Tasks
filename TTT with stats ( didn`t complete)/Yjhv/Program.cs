using System;
using System.Collections.Generic;
using System.Linq;
namespace Доска_для_крестиков_ноликов
{
    class Player
    {
        public string name;
        public int wins;
        public int games;
        public Player(string name,int wins,int games)
        {
            this.name = name;
            this.wins = wins;
            this.games = games;
        }
        public void Info()
        {
            Console.WriteLine($"{this.name} {this.wins}/{this.games}");
        }
    }
    class Program
    {
        static string[] pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        static List<Player> players = new List<Player>();
        static void Main(string[] args)
        {

            players.Add(new Player("Musyaka",99999,1));
            bool i = true;
            while (i == true)
            {
                for(int u = 0; u < pos.Length; u++)
                {
                    pos[u] = " ";
                }
                Console.WriteLine(" Новая игра -1");
                Console.WriteLine(" Об авторе –2");
                Console.WriteLine(" Выход-3");
                string move = Console.ReadLine();
                bool i2 = true;
               
                    switch (move)
                    {
                        case "1":
                        int games = 0;
                        int games2 = 0;
                        games += 1;
                        games2 += 1;
                        int wins = 0;
                        int wins2 = 0;
                            Console.Clear();
                            Console.WriteLine("New Game");
                            string whose_move = "X";
                            Console.WriteLine("Welcome to tic-tac-toe!");
                        Console.Write("X name:");
                        string name1 = Console.ReadLine();
                        Console.Write("O name:");
                        string name2 = Console.ReadLine();

                        DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                           if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name1, wins, games));
                                }
                            continue;
                           }
                            whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name2)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name2, wins2, games2));
                                }

                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name1, wins, games));
                                }

                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name2)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name2, wins2, games2));
                                }
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name1, wins, games));
                                }
                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else if(true)
                                {
                                    players.Add(new Player(name2, wins, games));
                                }

                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name1, wins, games));
                                }
                            continue;
                        }
                        whose_move = "O";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name2)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name2, wins2, games2));
                                }
                            continue;
                        }
                        whose_move = "X";
                            DrawBoard();
                            Console.WriteLine($"{whose_move} move:");
                            Move(pos, whose_move);
                            i2 = Win();
                        if (i2 == false)
                        {
                            foreach (Player n in players.ToList())
                                if (n.name == name1)
                                {
                                    Checker(name1);

                                }
                                else
                                {
                                    players.Add(new Player(name1, wins, games));
                                }
                            continue;
                        }
                        whose_move = "O";

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
                    case "4":
                        foreach (Player t in players)
                            t.Info();
                        Console.ReadLine();
                        continue;
                    }
                
               
            }
           
        }
        static void Checker(string name)
        {
            foreach(Player n in players)
                if (n.name == name)
                {
                    Player element = n;
                    int index = players.IndexOf(element);
                    players[index].wins += 1;
                    players[index].games += 1;
                    players[index].Info();
                }
                

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
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") 
            {
                return true;
            }
            else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
            {
                return true;
            }
            else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O")
            {
                return true;
            }
            else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
            {
                return true;
            }

            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")
            {
                return true;
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
            {
                return true;
            }
            else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
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

            if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X")
            {
                return true;
            }
            else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
            {
                return true;
            }
            else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X")
            {
                return true;
            }
            else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
            {
                return true;
            }

            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X")
            {
                return true;
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
            {
                return true;
            }
            else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
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
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
        }
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
