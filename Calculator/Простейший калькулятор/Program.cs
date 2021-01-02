using System;

namespace Простейший_калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данный калькулятор выполняет простейшие математические действия (+, -, *, /) над двумя цифрами");
            Console.WriteLine("Введите цифру");
            double FirstNumber  =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операциюs (+, -, *, /)");
            char Symbol = Convert.ToChar(Console.ReadLine());
            switch (Symbol)
            {
                case '+':
                    Console.WriteLine( FirstNumber+ SecondNumber);
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
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
