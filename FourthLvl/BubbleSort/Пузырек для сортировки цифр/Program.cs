using System;

namespace Пузырек_для_сортировки_цифр
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел для сортировки:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.WriteLine("Отсортированные числа:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }

        static int[] BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
