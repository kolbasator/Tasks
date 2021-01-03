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
            int valueOfContacts = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < valueOfContacts + 1; i++)
            {
                Console.WriteLine($"Введите данные {i} контакта:");
                Console.WriteLine("Введите имя:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                string lastName1 = Console.ReadLine();
                Console.WriteLine("Введите номер телефона:");
                string phone1 = Console.ReadLine();
                Console.WriteLine("Введите электронную почту :");
                string email1 = Console.ReadLine();
                contacts.Add(new Contact(name1, lastName1, phone1, email1));
            }
            foreach (Contact i in contacts)
                i.DisplayInfo();
            Console.WriteLine("");
            Console.ReadLine();

        }

    }
}
