using System;

namespace Генератор_рандомных_чисел
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
