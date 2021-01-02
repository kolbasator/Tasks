using System;

namespace Гистограмма
{
    class Program
    {
        static void Main(string[] args)
        {
            string One = "";
            string Two = "";
            string Three = "";
            string Four = "";
            string Five = "";
            Console.WriteLine("How many numbers do you want to enter: ");
            int value_of_numbers = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[value_of_numbers += 1];
            for (int j = 1; j < array.Length; j++)
            {
                Console.WriteLine($"Enter number {j}");
                bool h = true;
                while (h)
                {

                    int array_value = Convert.ToInt32(Console.ReadLine());
                    if (array_value <= 5)
                    {
                        array[j] = array_value;
                        switch (array_value)
                        {
                            case 1:
                                One += "*";
                                break;
                            case 2:
                                Two += "*";
                                break;
                            case 3:
                                Three += "*";
                                break;
                            case 4:
                                Four += "*";
                                break;
                            case 5:
                                Five += "*";
                                break;
                        }
                        h = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect number.Please write number from 1 to 5!");
                        continue;
                    }

                }

            }
            Console.WriteLine($"1:{One}\n2:{Two}\n3:{Three}\n4:{Four}\n5:{Five}");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
