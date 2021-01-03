using System;
using System.Collections.Generic;
using System.Text;

namespace Структура_для_хранения_данных_пользователя
{
    struct User
    {
        public string name;
        public string lastName;
        public string phoneNumber;
        public string email;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Lastname: {lastName}\nEmail:{email}\nPhone number:{phoneNumber}");
        }
    }
}
