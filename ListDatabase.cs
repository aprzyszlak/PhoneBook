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
        static List<Contact> list = new List<Contact>();

        static public List<Contact> AddContact(Contact contact)
        {
            list.Add(contact);
            return list;
        }

        static public void ShowAll()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.Name}, Number: {item.Number}");
            }
        }

        static public void GetContactPerNumber(int number)
        {
            List<Contact> nowa = new List<Contact>();
            nowa = list.Where(e => e.Number == number).ToList();
            foreach (var item in nowa)
            {
                Console.WriteLine($"Name: {item.Name}, Number: {item.Number}");
            }
        }

        static public void GetContactPerName(string name)
        {
            List<Contact> nowa = new List<Contact>();
            nowa = list.Where(e => e.Name == name).ToList();
            foreach (var item in nowa)
            {
                Console.WriteLine($"Name: {item.Name}, Number: {item.Number}");
            }
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
