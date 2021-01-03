using System;

namespace Информация_о_пользователе
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа выведет ваши данные в определенном порядке.Введите ваше имя:");
            string firstName=Console.ReadLine();
            Console.WriteLine("Введите Фамилию:");
            string familyName = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            string street= Console.ReadLine();
            Console.WriteLine("Введите номер дома:");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры:");
            string flatNumber = Console.ReadLine();
            Console.WriteLine("Введите почтовый индекс:");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Введите название города ");
            string cityName = Console.ReadLine();
            Console.WriteLine($"{firstName} {familyName} \nSt. {street} {houseNumber}/{flatNumber} \n{zipCode} {cityName}");
            Console.ReadLine();
        }
    }
}
