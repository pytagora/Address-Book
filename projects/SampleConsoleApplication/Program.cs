using System;
using static Model.Contact;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            Console.WriteLine("\t***Welcome to my console application!!!***");
            Console.WriteLine("\n\n\t\tADDRESS BOOK");
            Console.WriteLine("\n\nCONTACT FORM: ");
            Console.Write("\nEnter contact's first name: ");
            contact.FirstName = Console.ReadLine(); 
            Console.WriteLine("Enter contact's last name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("To add contact's birthplace press key 'A': ");
            char key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's birthplace: ");
                contact.BirthPlace = Console.ReadLine();
            }
            Console.WriteLine("To add contact's birthday press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's birthday in the format MM/dd/yyyy: ");
                string birthday = Console.ReadLine();
                DateTime dateTime = Convert.ToDateTime(birthday);
                contact.BirthDay = dateTime;
            }
            Console.WriteLine("To add contact's gender press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's gender: ");
                contact.Gender = Console.ReadLine();
            }
            Console.WriteLine("\nTo add contact's email press key 'A': ");
            key = Console.ReadKey().KeyChar;
            while(key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter contact's new email: ");
                string stringEmail = Console.ReadLine();
                Email email = new Email(stringEmail);
                contact.AddEmail(email);
                Console.WriteLine("To add another contact's email press 'A': ");
                key = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nTo add comment for contact press key 'A': ");
            key = Console.ReadKey().KeyChar;
            if (key == 'A' || key == 'a')
            {
                Console.WriteLine("\nEnter comment for the contact: ");
                contact.Comment = Console.ReadLine();
            }
            Console.WriteLine("\nContact with a name '{0}' and email '{1}' birthplace '{2}' and birthday '{3}' gender '{4}' and comment '{5}' created!\n", contact.FirstName + contact.LastName, contact.emails[0].Name, contact.BirthPlace, contact.BirthDay, contact.Gender, contact.Comment);
            Console.WriteLine("\nProcess done. Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}