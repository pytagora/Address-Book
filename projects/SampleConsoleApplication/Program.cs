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
            string mail = Console.ReadLine();
            Email novi = new Email(mail);
            Contact contact = new Contact(name, novi);
            Console.WriteLine("\n\nContact name '{0}' with an email '{1}' is created.\n\n", contact.FirstName, novi);
            Console.WriteLine("Add second email: ");
            string read = Console.ReadLine();
            Email mejl = new Email(read);
            contact.AddEmail(mejl);
            Console.WriteLine("\r\nProcess done. Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}