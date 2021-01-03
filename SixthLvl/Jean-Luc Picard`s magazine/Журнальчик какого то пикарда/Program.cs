using System;
using System.IO;
using System.Collections.Generic;

namespace Журнальчик_какого_то_пикарда
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = DateTime.Today.ToLongDateString();
            StreamWriter sw = new StreamWriter($"{date}.txt");


            bool i = true;
            bool j = true;
            List<string> text = new List<string>();
            Console.WriteLine("Эта программа служит для записи текста в журнал Жан-Люк Пикарда .Для начала записи в журнал введите старт ,для остановки записи введите стоп, для выхода из программы введите выход. Вводить эти команды следует с большой буквы.");
            while (j)
            {


                string agree = Console.ReadLine();
                switch (agree)
                {
                    case "Выход":
                        j = false;
                        break;
                    case "Старт":
                        Console.Clear();
                        while (i == true)
                        {

                            string myString = Console.ReadLine();
                            if (myString == "Стоп")
                            {
                                text.Remove("Стоп");
                                Console.Clear();
                                i = false;
                            }
                            else
                            {
                                text.Add($"{myString} \n");
                            }
                        }
                        continue;
                    default:
                        continue;
                }
            }

            using (sw)
            {
                sw.WriteLine("Captain’s log");
                sw.WriteLine($"Stardate {date}");
                foreach (string i3 in text)
                    sw.WriteLine(i3);
                sw.WriteLine("Jean-Luc Picard");

            }


        }
    }
}
