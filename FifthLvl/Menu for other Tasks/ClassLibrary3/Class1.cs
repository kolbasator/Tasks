using System;
using System.Collections.Generic;
namespace ClassLibrary3
{
    public static class ThirdLvl
    {
        static string[] Pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static void Display()
        {
            bool i = true;
            while (i)
            {
                Console.WriteLine("Catalog:");
                Console.WriteLine("Крестики-нолики-1\nНахождение простых чисел с помощью решета Эратосфена-2\nСортировка чисел в порядке возрастания-3\nЧисла от пользователя в обратном порядке-4\nГистограмма\nСреднее число среди ваших чисел-6\nВыход-7");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        TTT();
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
                        SieveEratosphen();
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
                        BubbleSortResult();
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
                        Reverse_Numbers();
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
                        Histogram();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree5 = Console.ReadLine();
                        if (agree5 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "6":
                        Average_Number_in_Array();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree6 = Console.ReadLine();
                        if (agree6 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "7":
                        i = false;
                        break;
                }
            }
        }
        public static void TTT()
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
        public static void Reverse_Numbers()
        {
            int i;
            int[] arr = new int[21];
            Console.WriteLine("Эта программа распечатает 20 чисел в обратном порядке.");
            Console.WriteLine("Введите 20 чисел:");
            for (i = 1; i <= 20; i++)
            {

                Console.WriteLine($"Введите {i} число:");
                arr[i] = Convert.ToInt32((Console.ReadLine()));
            }
            for (i = 20; i >= 1; i--)
                Console.WriteLine(arr[i]);
            Console.ReadLine();
        }
        public static void Average_Number_in_Array()
        {
            Console.WriteLine("How many numbers:");
            string value = Console.ReadLine();
            double[] array = new double[Convert.ToInt32(value)];
            Console.WriteLine("put your numbers:");
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = Convert.ToDouble(Console.ReadLine());
            }
            double total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }
            double average = total / array.Length;
            Console.WriteLine($"The average of numbers {average}.Thanks for using our program!");
            Console.ReadLine();
        }
        public static void Histogram()
        {
            string one = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";
            Console.WriteLine("How many numbers do you want to enter: ");
            int value_of_numbers = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[value_of_numbers += 1];
            for (int j = 1; j < array.Length; j++)
            {
                Console.WriteLine($"Enter number {j}");
                bool h = true;
                while (h == true)
                {

                    int array_value = Convert.ToInt32(Console.ReadLine());
                    if (array_value <= 5)
                    {
                        array[j] = array_value;
                        switch (array_value)
                        {
                            case 1:
                                one += "*";
                                break;
                            case 2:
                                two += "*";
                                break;
                            case 3:
                                three += "*";
                                break;
                            case 4:
                                four += "*";
                                break;
                            case 5:
                                five += "*";
                                break;
                        }
                        h = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number.Please write number from 1 to 5!");
                        continue;
                    }

                }

            }
            Console.WriteLine($"1:{one}\n2:{two}\n3:{three}\n4:{four}\n5:{five}");
            Console.ReadLine();
            Console.ReadLine();
        }
        static List<uint> Eratosphen(uint n)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers;
        }
        public static void SieveEratosphen()
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            var numbers = Eratosphen(n);
            Console.WriteLine("Простые числа до заданного {0}:", n);
            Console.WriteLine(string.Join(", ", numbers));
            Console.ReadLine();
        }
        public static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static void BubbleSortResult()
        {

            Console.WriteLine("Количество чисел для сортировки:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.WriteLine("Отсортированные числа:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }
    }
}
