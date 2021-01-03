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
                string move = Console.ReadLine();
                bool i2 = true;

                switch (move)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("New Game");
                        string whoseMove = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "O";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whoseMove = "X";
                        Game.DrawBoard();
                        Console.WriteLine($"{whoseMove} move:");
                        Game.MoveInTheGame(whoseMove);
                        i2 = Game.Win();
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


    }

}
