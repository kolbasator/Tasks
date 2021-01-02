using System;
using ClassLibrary1;
using ClassLibrary2;
using System.Collections.Generic;
using ClassLibrary3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool i = true;
            while (i)
            {
                Console.WriteLine("FirstLvl-1\nSecondLvl-2\nThridLvl-3");
                string move = Console.ReadLine();
                switch (move)
                {
                    case "1":
                        Console.Clear();
                        FirstLvl.Display();
                        break;
                    case "2":
                        Console.Clear();
                        SecondLvl.Display();
                        break;
                    case "3":
                        Console.Clear();
                        ThirdLvl.Display();
                        break;
                    default:
                        continue;
                }
            }
      
        }
    }
}
