using System;
using System.Collections.Generic;
using System.Collections;

namespace Штука_для_создания_списка_контактов_и_их_вывода
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList contacts = new ArrayList();
            Console.WriteLine("Данная программа создает список контактов ,которые предоставите вы.");
            Console.WriteLine("Введите количество контактов:");
            int ValueOfContacts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ValueOfContacts + 1; i++)
            {
                Console.WriteLine($"Введите данные {i} контакта:");
                Console.WriteLine("Введите имя:");
                string Name1 = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                string Lastname1 = Console.ReadLine();
                Console.WriteLine("Введите номер телефона:");
                string Phone1 = Console.ReadLine();
                Console.WriteLine("Введите электронную почту :");
                string Email1 = Console.ReadLine();
                contacts.Add(new Contact(Name1, Lastname1, Phone1, Email1));
            }
            foreach (Contact i in contacts)
                i.DisplayInfo();
            Console.WriteLine("");
            Console.ReadLine();

        }

    }
}
