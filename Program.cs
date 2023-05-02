using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Phone Book application, check the option you want to:");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Show contact per number");
                Console.WriteLine("3. Show all contacts");
                Console.WriteLine("4. Show contact per name");
                Console.WriteLine("5. Remove contact");

                var userInput = Console.ReadLine();
                if (userInput != null)
                {
                    if (userInput == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("1. Add new contact");
                        Console.WriteLine("Type name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Type nuber:");
                        int number = int.Parse(Console.ReadLine());
                        Contact contact = new Contact(name, number);
                        ListDatabase.AddContact(contact);
                    }
                    else if (userInput == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("2. Show contact per number");
                        Console.WriteLine("Type number to find:");
                        int number = int.Parse(Console.ReadLine());
                        ListDatabase.GetContactPerNumber(number);
                    }
                    else if (userInput == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("3. Show all contacts");
                        ListDatabase.ShowAll();

                    }
                    else if (userInput == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("4. Show contact per name");
                        Console.WriteLine("Type contact to find:");
                        string name = Console.ReadLine();
                        ListDatabase.GetContactPerName(name);
                    }
                    else if (userInput == "5")
                    {
                        Console.Clear();
                        Console.WriteLine("5. Remove contact:");
                        Console.WriteLine("Type contact name to remove:");
                        string name = Console.ReadLine();
                        ListDatabase.DeleteContact(name);
                        ListDatabase.ShowAll();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect value");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect value");
                }
            }
            


            

            Console.ReadKey();
        }

        
    }
}
