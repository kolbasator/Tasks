using System;
using System.Collections.Generic;
using System.Text;

namespace Штука_для_создания_списка_контактов_и_их_вывода
{
    public struct Contact
    {
        public string Name;
        public string LastName;
        public string Email;
        public string Phone;
        public Contact(string name, string lastname, string phone, string email)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Phone = phone;
            this.Email = email;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  Lastname: {LastName}\nEmail:{Email}\nPhone number:{Phone}");
        }
    }
}
