using System;
using System.Collections.Generic;
using System.Text;

namespace Структура_для_хранения_данных_пользователя
{
    struct User
    {
        public string Name;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  Lastname: {LastName}\nEmail:{Email}\nPhone number:{PhoneNumber}");
        }
    }
}
