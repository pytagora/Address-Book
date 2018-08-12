using System;
using System.Collections.Generic;

namespace Model
{
    public class Contact
    {
        private readonly string name = string.Empty;
        private readonly List<Email> emails = null;

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
            this.name = name;
            emails = new List<Email>();

            this.AddEmail(email);
        }

        public void AddEmail(Email email)
        {
            emails.Add(email);
        }
        public class Email
        {
            private string emailName = string.Empty;

            public Email(string name)
            {
                emailName = name;
            }

            public string Name
            {
                get { return emailName; }

                set { emailName = value; }
            }
        }
    }
}
