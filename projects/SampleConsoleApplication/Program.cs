using System;
using static Model.Contact;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of the contact: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter his/her email: ");
            string firstEmail = Console.ReadLine();
            Email secondEmail = new Email(firstEmail);
            Contact contact = new Contact(name, secondEmail);
            Console.WriteLine("\n\nContact name '{0}' with an email '{1}' is created.\n\n", contact.FirstName, secondEmail);
            Console.WriteLine("Add second email: ");
            string read = Console.ReadLine();
            Email thirdEmail = new Email(read);
            contact.AddEmail(thirdEmail);
            Console.WriteLine("\r\nProcess done. Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}