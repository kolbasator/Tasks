using System;

namespace Числа_от_пользователя_в_порядлке_возрастания
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа записывает числа в порядке возрастания с помощью сортировки пузырьком (разумовский оценит)");
          
            int[] array = new int[3];
            Console.WriteLine("Введите первое число:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string b=Console.ReadLine();
            Console.WriteLine("Введите третье число:");
            string c = Console.ReadLine();
            array[0] = Convert.ToInt32(a);
            array[1] = Convert.ToInt32(b);
            array[2] = Convert.ToInt32(c);
           Sortirovshik(array);
            Console.WriteLine("Спасибо за пользование нашей программой !Удачи!");
            Console.ReadLine();
            Console.ReadLine();
        }
        static int[] Sortirovshik(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int I = i + 1; I < arr.Length; I++)
                {
                    if (arr[i] > arr[I])
                    {
                        temp = arr[i];
                        arr[i] = arr[I];
                        arr[I] = temp;
                    }
                }
            }
            foreach (int i in arr)
                Console.WriteLine(i);
            return arr;
        }
    }
}
