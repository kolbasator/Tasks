using System;

namespace Информация_о_пользователе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа выведет ваши данные в определенном порядке.Введите ваше имя:");
            string name=Console.ReadLine();
            Console.WriteLine("Введите Фамилию:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string street= Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string house_number = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string flat_number = Console.ReadLine();
            Console.WriteLine("Введите почтовый индекс:");
            string zip_code = Console.ReadLine();
            Console.WriteLine("Введите название города ");
            string city_name = Console.ReadLine();
            Console.WriteLine($"{name} {lastname} \nSt. {street} {house_number}/{flat_number} \n{zip_code} {city_name}");
            Console.ReadLine();
        }
    }
}
