using System;

namespace ClassLibrary2
{
    public static class SecondLvl
    {
        public static void Display()
        {

            bool i = true;
            while (i == true)
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
            while (i == true)
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
            string house_number = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string flat_number = Console.ReadLine();
            Console.WriteLine("Введите почтовый индекс:");
            string zip_code = Console.ReadLine();
            Console.WriteLine("Введите название города ");
            string city_name = Console.ReadLine();
            Console.WriteLine($"{name} {lastname} \nSt. {street} {house_number}/{flat_number} \n{zip_code} {city_name}");
            Console.ReadLine();
        }
        public static void Menu()
        {
            bool i = true;
            while (i == true)
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
                        string whose_move = "X";
                        Console.WriteLine("Welcome to tic-tac-toe!");
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "O";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
                        i2 = Win();
                        if (i2 == false)
                        {
                            continue;
                        }
                        whose_move = "X";
                        DrawBoard();
                        Console.WriteLine($"{whose_move} move:");
                        Move(pos, whose_move);
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
            static string[] pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
    }
}
