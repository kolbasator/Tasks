using System;

namespace Прямоугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа рисует прямоугольники из *.Введите ширину:");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину:");
            int Height = Convert.ToInt32(Console.ReadLine());
            string FirstString = "";
            string SecondString = $"{FirstString}\n";
            for (int i = 0; i < Width; i++)
            {
                FirstString += "*";
            }
            for (int i = 0; i < Height; i++)
            {
                SecondString += $"{FirstString}\n";
            }
            Console.WriteLine(SecondString);
            Console.WriteLine("Спасибо за пользование программой!");
            Console.ReadLine();
        }
    }
}
