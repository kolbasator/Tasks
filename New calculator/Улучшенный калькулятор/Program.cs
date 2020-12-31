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
                double FirstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вторую цифру");
                double SecondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операциюs (+, -, *, /)");
                char Symbol = Convert.ToChar(Console.ReadLine());
                switch (Symbol)
                {
                    case '+':
                        Console.WriteLine(FirstNumber + SecondNumber);
                        break;
                    case '-':
                        Console.WriteLine(FirstNumber - SecondNumber);
                        break;
                    case '*':
                        Console.WriteLine(FirstNumber * SecondNumber);
                        break;
                    case '/':
                        Console.WriteLine(FirstNumber / SecondNumber);
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
