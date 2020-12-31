using System;

namespace Информация_о_пользователе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа выведет ваши данные в определенном порядке.Введите ваше имя:");
            string FirstName=Console.ReadLine();
            Console.WriteLine("Введите Фамилию:");
            string FamilyName = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string Street= Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string HouseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string FlatNumber = Console.ReadLine();
            Console.WriteLine("Введите почтовый индекс:");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Введите название города ");
            string CityName = Console.ReadLine();
            Console.WriteLine($"{FirstName} {FamilyName} \nSt. {Street} {HouseNumber}/{FlatNumber} \n{ZipCode} {CityName}");
            Console.ReadLine();
        }
    }
}
