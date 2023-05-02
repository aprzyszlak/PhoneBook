using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook
{
    class ListDatabase
    {
        public static List<Contact> list { get; set; } = new List<Contact>();

        static public void AddContact(Contact contact)
        {
            list.Add(contact);
        }

        static public void ShowAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.Name}, Number: {item.Number}");
            }
        }

        static private void DisplayContact(Contact contact)
        {
            Console.WriteLine($"Name: {contact.Name}, Number: {contact.Number}");
        }
        static public void GetContactPerNumber(int number)
        {
            var contact = list.FirstOrDefault(e => e.Number == number);
            DisplayContact(contact);
        }

        static public void GetContactPerName(string name)
        {
            var contact = list.FirstOrDefault(x => x.Name == name);
            DisplayContact(contact);
        }

        static public void DeleteContact(string name)
        {
            var contactToDelete = list.FirstOrDefault(contact => contact.Name == name);
            if (contactToDelete != null)
            {
                list.Remove(contactToDelete);
            }
        }
    }
}
