using System;

namespace Структура_для_хранения_данных_пользователя
{
    class Program
    {
        static void Main(string[] args)
        {
            Me me;
            User user;
            me.Name = "Musyaka";
            me.LastName = "Kolbasyaka";
            me.Email = "kolbasator228@gmail.com";
            me.PhoneNumber = "8-800-555-3535";
            Console.WriteLine("Данная программа возьмет ваши контактные данные и отобразит их в особом порядке.Введите имя:");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Введите вашу электронную почту:");
            user.Email = Console.ReadLine();
            Console.WriteLine("Введите ваш номер телефона:");
            user.PhoneNumber = Console.ReadLine();
            user.DisplayInfo();

        }
    }
   
   
}
