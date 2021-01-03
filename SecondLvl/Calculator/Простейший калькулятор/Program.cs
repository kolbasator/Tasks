using System;

namespace Простейший_калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данный калькулятор выполняет простейшие математические действия (+, -, *, /) над двумя цифрами");
            Console.WriteLine("Введите цифру");
            double firstNumber  =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операциюs (+, -, *, /)");
            char symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    Console.WriteLine( firstNumber+ secondNumber);
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
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
