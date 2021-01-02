using System;
using System.IO;
using System.Collections.Generic;

namespace Журнальчик_какого_то_пикарда
{
    class Program
    {
        static void Main(string[] args)
        {
            string Date = DateTime.Today.ToLongDateString();
            StreamWriter sw = new StreamWriter($"{Date}.txt");


            bool i = true;
            bool j = true;
            List<string> text = new List<string>();
            Console.WriteLine("Эта программа служит для записи текста в журнал Жан-Люк Пикарда .Для начала записи в журнал введите старт ,для остановки записи введите стоп, для выхода из программы введите выход. Вводить эти команды следует с большой буквы.");
            while (j)
            {


                string Agree = Console.ReadLine();
                switch (Agree)
                {
                    case "Выход":
                        j = false;
                        break;
                    case "Старт":
                        Console.Clear();
                        while (i == true)
                        {

                            string my_string = Console.ReadLine();
                            if (my_string == "Стоп")
                            {
                                text.Remove("Стоп");
                                Console.Clear();
                                i = false;
                            }
                            else
                            {
                                text.Add($"{my_string} \n");
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
                sw.WriteLine($"Stardate {Date}");
                foreach (string i3 in text)
                    sw.WriteLine(i3);
                sw.WriteLine("Jean-Luc Picard");

            }


        }
    }
}
