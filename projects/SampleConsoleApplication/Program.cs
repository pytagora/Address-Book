using System;
using static Model.Contact;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Email hotmail = new Email("perica@hotmail.com");
            Contact contact = new Contact("ivica", hotmail);
            string read = Console.ReadLine();
            Email mejl = new Email(read);
            contact.AddEmail(mejl);
            Console.WriteLine("\r\nProcess done. Press any key to exit.");
            Console.ReadKey();
            return;
        }
    }
}