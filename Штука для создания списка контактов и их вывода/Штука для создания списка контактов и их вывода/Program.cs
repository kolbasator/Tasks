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
            int contacts_value = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < contacts_value+1; i++)
            {
                Console.WriteLine($"Введите данные {i} контакта:");
                Console.WriteLine("Введите имя:");
                string name1 = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                string lastname1 = Console.ReadLine();
                Console.WriteLine("Введите номер телефона:");
                string phone1 = Console.ReadLine();
                 Console.WriteLine("Введите электронную почту :");
                string email1 = Console.ReadLine();
                contacts.Add(new Contact(name1, lastname1, phone1, email1));
            }
            foreach (Contact i in contacts)
                i.DisplayInfo();
            Console.WriteLine("");
            Console.ReadLine();

        }
        public struct Contact
        {
            public string name;
            public string lastname;
            public string email;
            public string phone;
           public Contact(string name,string lastname,string phone,string email)
            {
                this.name = name;
                this.lastname = lastname;
                this.phone = phone;
                this.email = email;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}  Lastname: {lastname}\nEmail:{email}\nPhone number:{phone}");
            }
        }
    }
}
