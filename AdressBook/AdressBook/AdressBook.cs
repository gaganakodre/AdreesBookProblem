using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    internal class AdressBook1
    {
        
            public string FirstName { get; set; }
            //The get method returns the value of the variable name//The set method assigns a value to the name variable
            public string LastName { get; set; }
           
            public string PhoneNumber { get; set; }
            public string city  { get; set; }
            public string Zip { get; set; }
            public string Email { get; set; }
            public string[] Addresses { get; set; }
            public static List<AdressBook1> People = new List<AdressBook1>();

            public static void AddPerson()
            {
            
            AdressBook1 person = new AdressBook1();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter city name: ");
                person.city = Console.ReadLine();
                Console.Write("Enter zip number: ");
                person.Zip = Console.ReadLine();
                Console.Write("Enter Phone Number: ");
                person.Email = Console.ReadLine();
                Console.Write("Enter Phone Email: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Address 1: ");
                string[] addresses = new string[2];
                addresses[0] = Console.ReadLine();
                Console.Write("Enter Address 2 (Optional): ");
                addresses[1] = Console.ReadLine();
                person.Addresses = addresses;
                People.Add(person);
            }
        
    }
}
