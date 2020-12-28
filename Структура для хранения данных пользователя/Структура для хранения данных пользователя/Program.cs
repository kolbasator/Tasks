using System;

namespace Структура_для_хранения_данных_пользователя
{
    class Program
    {
        static void Main(string[] args)
        {
            Me me;
            User user;
            me.name = "Musyaka";
            me.lastname = "Kolbasyaka";
            me.email = "kolbasator228@gmail.com";
            me.phone_number = "8-800-555-3535";
            Console.WriteLine("Данная программа возьмет ваши контактные данные и отобразит их в особом порядке.Введите имя:");
            user.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            user.lastname = Console.ReadLine();
            Console.WriteLine("Введите вашу электронную почту:");
            user.email = Console.ReadLine();
            Console.WriteLine("Введите ваш номер телефона:");
            user.phone_number = Console.ReadLine();
            user.DisplayInfo();

        }
    }
    struct Me
    {
        public string name;
        public string lastname;
        public string phone_number;
        public string email;
    }
    struct User
    {
        public string name;
        public string lastname;
        public string phone_number;
        public string email;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Lastname: {lastname}\nEmail:{email}\nPhone number:{phone_number}");
        }
    }
}
