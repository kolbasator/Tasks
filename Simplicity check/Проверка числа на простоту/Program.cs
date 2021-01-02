using System;

namespace Проверка_числа_на_простоту
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа проверяет число на простоту .Введите число:");
            string NumberString = Console.ReadLine();
            bool Result = IsPrimeNumber(Convert.ToUInt16(NumberString));
            if (Result)
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
        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

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

            return result;
        }
    }
}
