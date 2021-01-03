using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Доска_для_крестиков_ноликов
{
    class Program
    {

        static List<Player> Players = new List<Player>();

        static void Main(string[] args)
        {

            bool i = true;
            while (i)
            {
                StreamWriter sw = new StreamWriter("Stats.txt");
                using (sw)
                {
                    foreach (Player n in Players)
                        sw.WriteLine($"{n.Name} {n.Wins}/{n.Games}");
                }
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
                Console.WriteLine(" Статистика-4");
                string move = Console.ReadLine();
                bool i2 = true;
                switch (move)
                {
                    case "1":
                        Board.One = " ";
                        Board.Two = " ";
                        Board.Three = " ";
                        Board.Four = " ";
                        Board.Five = " ";
                        Board.Six = " ";
                        Board.Seven = " ";
                        Board.Eight = " ";
                        Board.Nine = " ";
                        Console.Clear();
                        Console.WriteLine("New Game");
                        string whoseMove = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        Console.WriteLine("Имя первого игрока:");
                        string nameOfFirstPlayer = Console.ReadLine();
                        Console.WriteLine("Имя второго игрока:");
                        string nameOfSecondPlayer = Console.ReadLine();
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);
                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            Check(nameOfFirstPlayer, nameOfSecondPlayer, 0, 0, 0, 0, whoseMove);

                            continue;
                        }
                        whoseMove = "O";

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
                    case "4":
                        foreach (Player n in Players)
                            Console.WriteLine(n.Name);
                        Console.WriteLine("Для скольки игроков вывести статистику?(Один/Два)");
                        string whichMove = Console.ReadLine();
                        if (whichMove == "Один")
                        {
                            Console.Write("Введите ваше имя :");
                            string name = Console.ReadLine();
                            int index= Players.IndexOf(Players.Find(n => n.Name == name));
                            Console.WriteLine($"{Players[index].Name} {Players[index].Wins}/{Players[index].Games}");
                        }
                        else if (whichMove == "Два")
                        {
                            Console.Write("Введите имя первого игрока :");
                            string name = Console.ReadLine(); 
                            Console.Write("Введите имя второго игрока:");
                            string name2 = Console.ReadLine();
                            int index = Players.IndexOf(Players.Find(n => n.Name == name));
                            int index2 = Players.IndexOf(Players.Find(n => n.Name == name2));
                            Console.WriteLine($"{Players[index2].Name} {Players[index2].Wins}/{Players[index2].Games}");
                            Console.WriteLine($"{Players[index].Name} {Players[index].Wins}/{Players[index].Games}");

                        }
                        Console.ReadLine();
                        continue;


                }


            }

        }
        static void InfoAboutMe()
        {
            Console.Clear();
            Console.WriteLine("Имя-Кирилл\nФамилия-Чеботарев\nВозраст-12 лет\nПитомцы-Кошка Мусяка\nЛюбимое дело -программирование и спорт \nЯзык программирования-С#");
            Console.ReadLine();
        }
        static void Check(string name1, string name2, int games1, int games2, int wins1, int wins2, string whoseMove)
        {
            if (whoseMove == "X")
            {
                if (Players.Contains(Players.Find(n => n.Name == name1)))
                {
                    foreach (Player n in Players)
                        if (n.Name == name1)
                        {
                            int index = Players.IndexOf(n);
                            Players[index].Wins += 1;
                            Players[index].Games += 1;
                        }
                }
                else
                {
                    Players.Add(new Player(name1, games1 += 1, wins1 += 1));
                }
                if (Players.Contains(Players.Find(n => n.Name == name2)))
                {
                    foreach (Player n in Players)
                        if (n.Name == name2)
                        {
                            int index = Players.IndexOf(n);
                            Players[index].Games += 1;
                        }
                }
                else
                {
                    Players.Add(new Player(name2, games2 += 1, wins2));

                }
            }
            else if (whoseMove == "O")
            {

                if (Players.Contains(Players.Find(n => n.Name == name1)))
                {
                    foreach (Player n in Players)
                        if (n.Name == name1)
                        {
                            int index = Players.IndexOf(n);
                            Players[index].Games += 1;
                        }
                }
                else
                {
                    Players.Add(new Player(name1, games1 += 1, wins1));
                }

                if (Players.Contains(Players.Find(n => n.Name == name2)))
                {
                    foreach (Player n in Players)
                        if (n.Name == name2)
                        {
                            int index = Players.IndexOf(n);
                            Players[index].Wins += 1;
                            Players[index].Games += 1;
                        }
                }
                else
                {
                    Players.Add(new Player(name2, games2 += 1, wins2 += 1));
                }
            }


        }


    }

}
