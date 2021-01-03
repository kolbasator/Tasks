using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5 Нет ;
            //y = 0; не указан тип 
            //int x = Console.ReadLine();Нельзя переопределять переменную и засовывать поле для ввода в переменную типа инт 
            //Console.WriteLine(x / y);все нормульок
            int x = 5;
            int y = 0;
            Console.WriteLine(x / y);
            Console.ReadLine();
        }
    }
}
