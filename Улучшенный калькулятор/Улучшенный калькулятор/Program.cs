using System;

namespace Улучшенный_калькулятор
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
