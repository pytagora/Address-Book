using System;
using System.Collections.Generic;

namespace Model
{
    public class Contact
    {
        private readonly string Name = string.Empty;
        public List<Email> emails = null;
        public List<Number> numbers = null;
        public List<Address> addresses = null;
        public List<SocialAccount> socialAccounts = null;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthPlace { get; set; }

        public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string Comment { get; set; }

        public Contact()
        {
            emails = new List<Email>();
            numbers = new List<Number>();
            addresses = new List<Address>();
            socialAccounts = new List<SocialAccount>();
        }

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
            public string emailName = string.Empty;

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
            public string numberId = string.Empty;
            public Number(string name)
            {
                numberId = name;
            }

            public string Id
            {
                get { return numberId; }

                set { numberId = value; }
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
            public string addressName = string.Empty;

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
            public string socialAccountName = string.Empty;

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
