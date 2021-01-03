using System;

namespace ClassLibrary2
{
    public static class SecondLvl
    {
        public static void Display()
        {

            bool i = true;
            while (i)
            {
                Console.WriteLine("Catalog:");
                Console.WriteLine("Меню для какой то игры-1\nКрестики-нолики-2\nГенератор рандомных чисел-3\nИнформация о пользователе-4\nВыход-5");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        Menu();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree = Console.ReadLine();
                        if (agree == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "2":
                        Tic_Tac_Toe();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree2 = Console.ReadLine();
                        if (agree2 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "3":
                        RandomNumber();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree3 = Console.ReadLine();
                        if (agree3 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "4":
                        InfoAboutUser();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree4 = Console.ReadLine();
                        if (agree4 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "5":
                        i = false;
                        break;

                }
            }

        }
        public static void RandomNumber()
        {

            bool i = true;
            while (i)
            {
                Random rand = new Random();
                Console.WriteLine("Программа для генерации случайных чисел .");
                Console.WriteLine("Хотите сгенерировать случайное число?Да/Нет");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "Да":
                        Console.WriteLine(Convert.ToString(rand.Next(1000000)));
                        continue;
                    case "Нет":
                        i = false;
                        break;
                    default:
                        continue;
                }
            }
        }
        public static void InfoAboutUser()
        {
            Console.WriteLine("Данная программа выведет ваши данные в определенном порядке.Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string street = Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string flatNumber = Console.ReadLine();
            Console.WriteLine("Введите почтовый индекс:");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Введите название города ");
            string cityName = Console.ReadLine();
            Console.WriteLine($"{name} {lastname} \nSt. {street} {houseNumber}/{flatNumber} \n{zipCode} {cityName}");
            Console.ReadLine();
        }
        public static void Menu()
        {
            bool i = true;
            while (i)
            {
                Console.WriteLine(" Новая игра -1");
                Console.WriteLine(" Об авторе –2");
                Console.WriteLine(" Выход-3");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("New Game");
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
        public static void Tic_Tac_Toe()
        {
            bool i = true;
            while (i)
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
                        string whose_move = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(Pos, whose_move);
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
        static void DrawBoard()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[1], Pos[2], Pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[4], Pos[5], Pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", Pos[7], Pos[8], Pos[9]);
        }
        static void Move(string[] board, string wm)
        {
            bool i = true;
            while (i)
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
        static string[] Pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
    }
}
