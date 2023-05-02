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
            Console.WriteLine("Welcome to Phone Book application, check the option you want to:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Show contact per number");
            Console.WriteLine("3. Show all contacts");
            Console.WriteLine("4. Show contact per name");
            
            var userInput = Console.ReadLine();
            if (userInput != null) 
            {
                if (userInput == "1")
                {
                    Console.WriteLine("1. Add new contact");
                    Console.WriteLine("Type name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Type nuber:");
                    int number = int.Parse(Console.ReadLine());
                    Contact contact = new Contact(name, number);
                }
                if (userInput == "2")
                {
                    Console.WriteLine("2. Show contact per number");
                }
                if (userInput == "3")
                {
                    Console.WriteLine("3. Show all contacts");
                }
                if (userInput == "4")
                {
                    Console.WriteLine("4. Show contact per name");
                }
                else
                {
                    Console.WriteLine("Incorrect value"); 
                }
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }


            

            Console.ReadKey();
        }

        
    }
}
