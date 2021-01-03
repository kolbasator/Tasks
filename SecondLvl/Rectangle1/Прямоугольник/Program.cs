using System;

namespace Прямоугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа рисует прямоугольники из *.Введите ширину:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину:");
            int height = Convert.ToInt32(Console.ReadLine());
            string firstString = "";
            string secondString = $"{firstString}\n";
            for (int i = 0; i < width; i++)
            {
                firstString += "*";
            }
            for (int i = 0; i < height; i++)
            {
                secondString += $"{firstString}\n";
            }
            Console.WriteLine(secondString);
            Console.WriteLine("Спасибо за пользование программой!");
            Console.ReadLine();
        }
    }
}
