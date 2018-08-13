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
            Console.WriteLine("\nContact name '{0}' with an email '{1}' is created.\n\n", contact.FirstName, contact.emails[0].Name);
            Console.WriteLine("Add second email: ");
            string read = Console.ReadLine();
            Email thirdEmail = new Email(read);
            contact.AddEmail(thirdEmail);
            Contact user = new Contact();
            Console.WriteLine("Enter first name for second contact: ");
            string firstName = Console.ReadLine();
            user.FirstName = firstName;
            Console.WriteLine("Enter last name for second contact: ");
            string lastName = Console.ReadLine();
            user.LastName = lastName;
            Console.WriteLine("Enter mail for second contact: ");
            string stringMail = Console.ReadLine();
            Email mail = new Email(stringMail);
            user.AddEmail(mail);
            Console.WriteLine("Contact with a name '{0}' and email '{1}' created!\n", user.FirstName + user.LastName, user.emails[0].Name);
            Console.WriteLine("\r\nProcess done. Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}