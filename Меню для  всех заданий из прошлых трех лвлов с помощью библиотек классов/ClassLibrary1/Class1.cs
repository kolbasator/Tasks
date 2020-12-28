using System;

namespace ClassLibrary1
{
    public static class FirstLvl
    {
        public static void Display()
        {
            bool i = true;
            while (i == true)
            {
                Console.WriteLine("Catalog:");
                Console.WriteLine("Калькулятор-1\nУлучшенный калькулятор-2\nДоска для крестиков-ноликов-3\nРисователь треугольников-4\nРисователь прямоугольников-5\nРешатель примера -6\nВозводилка в степень -7\nПроверка числа на простоту-8\nПроверка числа на четность-9\nСортировщик трех чисел-10\nВыход-11");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        Calculator();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree=Console.ReadLine();
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
                        SecondCalculator();
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
                        TTTBoard();
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
                        Triangle();
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
                        Rectangle();
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
                        Equation();
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
                        Pow();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree7 = Console.ReadLine();
                        if (agree7 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "8":
                        EasyCheck();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree8 = Console.ReadLine();
                        if (agree8 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "9":
                        ParityCheck();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree9 = Console.ReadLine();
                        if (agree9 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "10":
                        ThreeNumbersSort();
                        Console.WriteLine("Вернуться в меню?Да/Нет");
                        string agree10 = Console.ReadLine();
                        if (agree10 == "Да")
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            i = false;
                        }
                        break;
                    case "11":
                        i = false;
                        break;
                }
            }
            

        }
        static void ThreeNumbersSort()
        {
            Console.WriteLine("Данная программа записывает числа в порядке возрастания с помощью сортировки пузырьком (разумовский оценит)");

            int[] array = new int[3];
            Console.WriteLine("Введите первое число:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string b = Console.ReadLine();
            Console.WriteLine("Введите третье число:");
            string c = Console.ReadLine();
            array[0] = Convert.ToInt32(a);
            array[1] = Convert.ToInt32(b);
            array[2] = Convert.ToInt32(c);
            Sortirovshik(array);
            Console.WriteLine("Спасибо за пользование нашей программой !Удачи!");
            Console.ReadLine();
            Console.ReadLine();
        }
        static int[] Sortirovshik(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int I = i + 1; I < arr.Length; I++)
                {
                    if (arr[i] > arr[I])
                    {
                        temp = arr[i];
                        arr[i] = arr[I];
                        arr[I] = temp;
                    }
                }
            }
            foreach (int i in arr)
                Console.WriteLine(i);
            return arr;
        }
        static void Equation()
        {
            Console.WriteLine("Эта программа решит вам пример типа а*б/а+б.Введите а:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите б :");
            string b = Console.ReadLine();
            double a_number = Convert.ToDouble(a);
            double b_number = Convert.ToDouble(b);
            double result = Math.Round(Counter(a_number, b_number), 4);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        static double Counter(double a, double b)
        {
            double i = a + b;
            return a * b / i;
        }
        public static void SecondCalculator()
        {
            x:
            Console.WriteLine("Данный калькулятор выполняет простейшие математические действия (+, -, *, /) над двумя цифрами");
            Console.WriteLine("Введите цифру");
            string a_string = Console.ReadLine();
            Console.WriteLine("Введите вторую цифру");
            string b_string = Console.ReadLine();
            Console.WriteLine("Введите операциюs (+, -, *, /)");
            string symbol_string = Console.ReadLine();
            char symbol = Convert.ToChar(symbol_string);
            double a = Convert.ToDouble(a_string);
            double b = Convert.ToDouble(b_string);
            switch (symbol)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
            }
            Console.WriteLine("Хотите использовать калькулятор еще раз ?Да/Нет");
            string choose = Console.ReadLine();
            if (choose == "Да")
            {
                goto x;
            }
            Console.ReadLine();
            Console.ReadLine();
        }
        public static void Rectangle()
        {

            Console.WriteLine("Эта программа рисует прямоугольники из *.Введите ширину:");
            string width = Console.ReadLine();
            int users_width = Convert.ToInt32(width);
            Console.WriteLine("Введите длину:");
            string height = Console.ReadLine();
            int users_height = Convert.ToInt32(height);
            string first_string = "";
            string second_string = $"{first_string}\n";
            for (int i = 0; i < users_width; i++)
            {
                first_string += "*";
            }
            for (int i = 0; i < users_height; i++)
            {
                second_string += $"{first_string}\n";
            }
            Console.WriteLine(second_string);
            Console.WriteLine("Спасибо за пользование программой!");
            Console.ReadLine();
        }

        public static void Triangle()
        {

            int i;
            int j;
            int k;
            Console.WriteLine("Эта программа нарисует вам треугольник с указанной вами высотой.");
            Console.Write("Введите высоту : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
        public static void Pow()
        {
            Console.WriteLine("Данная программа возводит указанное число в указанную степень.");
            Console.WriteLine("Введите число:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите степень:");
            string b = Console.ReadLine();
            Console.WriteLine("Результат:");
            double a_number = Convert.ToDouble(a);
            double b_number = Convert.ToDouble(b);
            double result = Math.Pow(a_number, b_number);
            Console.WriteLine(Math.Round(result, 3));
            Console.ReadLine();
            
        }
        public static void TTTBoard()
        {
            string[] pos = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            string whose_move = "X";
            Console.WriteLine("Welcome to tic-tac-toe!");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "O";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "X";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "O";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "X";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "O";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "X";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "O";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "X";
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[1], pos[2], pos[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[4], pos[5], pos[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", pos[7], pos[8], pos[9]);
            Console.WriteLine($"{whose_move} move:");
            Move(pos, whose_move);
            whose_move = "O";
            Console.WriteLine("Game Over!");
            Console.ReadLine();
            Console.ReadLine();
        }
        public static void ParityCheck()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Доброго времени Суток !Данная программа проверяет чесло на четность.Введите число:");
            string number_string = Console.ReadLine();
            int number_int = Convert.ToInt32(number_string);
            bool number_bool = (number_int % 2) == 0; 
            if (number_bool == true)
            {
                Console.WriteLine("Число четное!");
            }
            else
            {
                Console.WriteLine("Число нечетное!");
            }
            Console.WriteLine("Спасибо за пользование программой!");
            Console.ReadLine();
            Console.ReadLine();
        }
        public static void EasyCheck()
        {
            Console.WriteLine("Эта программа проверяет число на простоту .Введите число:");
            string number_string = Console.ReadLine();
            var result = true;
            int n = Convert.ToInt32(number_string);
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

         
            if (result == true)
            {
                Console.WriteLine("Число простое!");
            }
            else
            {
                Console.WriteLine("Число составное!");
            }
            Console.WriteLine("Спасибо за пользование программой!");
            Console.ReadLine();
        }
        public static void Calculator()
        {
            Console.WriteLine("Данный калькулятор выполняет простейшие математические действия (+, -, *, /) над двумя цифрами");
            Console.WriteLine("Введите цифру");
            string a_string = Console.ReadLine();
            Console.WriteLine("Введите вторую цифру");
            string b_string = Console.ReadLine();
            Console.WriteLine("Введите операциюs (+, -, *, /)");
            string symbol_string = Console.ReadLine();
            char symbol = Convert.ToChar(symbol_string);
            double a = Convert.ToDouble(a_string);
            double b = Convert.ToDouble(b_string);
            switch (symbol)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
            }
            Console.ReadLine();
            Console.ReadLine();
        }
        public static void Move(string[] board, string wm)
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
