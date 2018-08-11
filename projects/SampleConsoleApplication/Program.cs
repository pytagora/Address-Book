using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SampleConsoleApplication.Contact;

namespace SampleConsoleApplication
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
    internal class Contact
    {
        private readonly string _name = string.Empty;
        private readonly List<Email> _emails = null;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthPlace { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Residence { get; set; }

        public long PhoneNumber { get; set; }

        public string SocialNetworkId { get; set; }

        public string Type { get; set; }

        public string Image { get; set; }

        public string Comment { get; set; }

        public Contact(string name, Email email)
        {
            _name = name;
            _emails = new List<Email>();
            Console.WriteLine("New contact created called '{0}'", name);

            this.AddEmail(email);
        }

        public void AddEmail(Email email)
        {
            _emails.Add(email);
            Console.WriteLine("Email called '{0}' added to contact called '{1}'", email.Name, _name);
            int s = _emails.Count;
            for (int i = 0; i < s; ++i)
            {
                Console.WriteLine("'{0}'. mail is '{1}'\n",i+1,_emails[i].Name);
            }
        }
        internal class Email
        {
            private string _emailName = string.Empty;

            public Email(string name)
            {
                _emailName = name;
                Console.WriteLine("New email created called '{0}'", name);
            }

            public string Name
            {
                get { return _emailName; }

                set { _emailName = value; }
            }
        }

    }
}