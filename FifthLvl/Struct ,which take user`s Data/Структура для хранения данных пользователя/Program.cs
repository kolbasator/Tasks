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
            me.lastName = "Kolbasyaka";
            me.email = "kolbasator228@gmail.com";
            me.phoneNumber = "8-800-555-3535";
            Console.WriteLine("Данная программа возьмет ваши контактные данные и отобразит их в особом порядке.Введите имя:");
            user.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            user.lastName = Console.ReadLine();
            Console.WriteLine("Введите вашу электронную почту:");
            user.email = Console.ReadLine();
            Console.WriteLine("Введите ваш номер телефона:");
            user.phoneNumber = Console.ReadLine();
            user.DisplayInfo();

        }
    }
   
   
}
