using System;

namespace Проверка_на__четность
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Доброго времени Суток !Данная программа проверяет чесло на четность.Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (Parity(number))
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
        static bool Parity(int i)
        {
           return (i % 2) == 0;
        }
    }
}
