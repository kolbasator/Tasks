using System;

namespace Гистограмма
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";
            Console.WriteLine("How many numbers do you want to enter: ");
            int value_of_numbers = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[value_of_numbers+=1];
            for (int j = 1; j < array.Length; j++)
            {
                Console.WriteLine($"Enter number {j}");
                bool h = true;
                while (h == true)
                {

                    int array_value = Convert.ToInt32(Console.ReadLine());
                    if(array_value<=5)
                    {
                        array[j] = array_value;
                        switch (array_value)
                        {
                            case 1:
                                one+="*";
                                break;
                            case 2:
                                two+= "*";
                                break;
                            case 3:
                                three += "*";
                                break;
                            case 4:
                                four += "*";
                                break;
                            case 5:
                                five += "*";
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
            Console.WriteLine($"1:{one}\n2:{two}\n3:{three}\n4:{four}\n5:{five}");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
