using System;

namespace Проверка_на__четность
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Доброго времени Суток !Данная программа проверяет чесло на четность.Введите число:");
            string number_string = Console.ReadLine();
            int number_int = Convert.ToInt32(number_string);
            bool number_bool= Chetnoe(number_int);
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
        static bool Chetnoe(int i)
        {
           return (i % 2) == 0;
        }
    }
}
