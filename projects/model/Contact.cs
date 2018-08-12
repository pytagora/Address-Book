using System;
using System.Collections.Generic;

namespace Model
{
    public class Contact
    {
        private readonly string Name = string.Empty;
        private readonly List<Email> emails = null;
        private readonly List<Number> numbers = null;
        private readonly List<Address> addresses = null;
        private readonly List<SocialAccount> socialAccounts = null;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthPlace { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Image { get; set; }

        public string Comment { get; set; }

        public Contact(string name, Email email)
        {
            FirstName = name;
            emails = new List<Email>();
            numbers = new List<Number>();
            addresses = new List<Address>();
            socialAccounts = new List<SocialAccount>();

            this.AddEmail(email);
        }

        public void AddEmail(Email email)
        {
            emails.Add(email);
        }
        public void RemoveEmail(Email email)
        {
            emails.Remove(email);
        }
        public void ChangeEmail(Email email, int i)
        {
            emails[i] = email;
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
        
        public void AddNumber(Number number)
        {
            numbers.Add(number);
        }
        public void RemoveNumber(Number number)
        {
            numbers.Remove(number);
        }
        public void ChangeNumber(Number number, int i)
        {
            numbers[i] = number;
        }
        public class Number
        {
            private string numberName = string.Empty;

            public Number(string name)
            {
                numberName = name;
            }

            public string Name
            {
                get { return numberName; }

                set { numberName = value; }
            }
        }
        public void AddAddress(Address address)
        {
            addresses.Add(address);
        }
        public void RemoveAddress(Address address)
        {
            addresses.Remove(address);
        }
        public void ChangeAddress(Address address, int i)
        {
            addresses[i] = address;
        }
        public class Address
        {
            private string addressName = string.Empty;

            public Address(string name)
            {
                addressName = name;
            }

            public string Name
            {
                get { return addressName; }

                set { addressName = value; }
            }
        }
        public void AddSocialAccount(SocialAccount socialAccount)
        {
            socialAccounts.Add(socialAccount);
        }
        public void RemoveSocialAccount(SocialAccount socialAccount)
        {
            socialAccounts.Remove(socialAccount);
        }
        public void ChangeSocialAccount(SocialAccount socialAccount, int i)
        {
            socialAccounts[i] = socialAccount;
        }
        public class SocialAccount
        {
            private string socialAccountName = string.Empty;

            public SocialAccount(string name)
            {
                socialAccountName = name;
            }

            public string Name
            {
                get { return socialAccountName;  }

                set { socialAccountName = value; }
            }
        }
    }
}
