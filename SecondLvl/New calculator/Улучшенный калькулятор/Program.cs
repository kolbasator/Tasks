using System;

namespace Улучшенный_калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i)
            {
                Console.WriteLine("Данный калькулятор выполняет простейшие математические действия (+, -, *, /) над двумя цифрами");
                Console.WriteLine("Введите цифру");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую цифру");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операциюs (+, -, *, /)");
                char symbol = Convert.ToChar(Console.ReadLine());
                switch (symbol)
                {
                    case '+':
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case '-':
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case '*':
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case '/':
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                }
                Console.WriteLine("Хотите использовать калькулятор еще раз ?Да/Нет");
                string Сhoose = Console.ReadLine();
                if (Сhoose == "Да")
                {
                    continue;
                }
                Console.ReadLine();
                Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
