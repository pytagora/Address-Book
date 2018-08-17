using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Model
{
    public partial class Contact
    {
        private readonly string Name = string.Empty;
        private List<Email> emails = new List<Email>();
        private List<Phone> phones = new List<Phone>();
        private List<Addreess> addreesses = new List<Addreess>();
        private List<SocialAccount> socialAccounts = new List<SocialAccount>();

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthPlace { get; set; }

        //public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string Comment { get; set; }

        public Contact()
        {
            emails = new List<Email>();
            phones = new List<Phone>();
            addreesses = new List<Addreess>();
            socialAccounts = new List<SocialAccount>();
        }
        public Contact(string name, Email email)
        {
            FirstName = name;
            emails = new List<Email>();
            phones = new List<Phone>();
            addreesses = new List<Addreess>();
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
        public IEnumerable<Email> GetEmails()
        {
            return emails;
        }
        public IEnumerable<Phone> GetPhones()
        {
            return phones;
        }
        public IEnumerable<SocialAccount> GetSocialAccounts()
        {
            return socialAccounts;
        }
        public IEnumerable<Addreess> GetAddreesses()
        {
            return addreesses;
        }
        public void AddNumber(Phone phone)
        {
            phones.Add(phone);
        }
        public void RemoveNumber(Phone phone)
        {
            phones.Remove(phone);
        }
        public void AddAddress(Addreess addreess)
        {
            addreesses.Add(addreess);
        }
        public void RemoveAddress(Addreess addreess)
        {
            addreesses.Remove(addreess);
        }
        public void AddSocialAccount(SocialAccount socialAccount)
        {
            socialAccounts.Add(socialAccount);
        }
        public void RemoveSocialAccount(SocialAccount socialAccount)
        {
            socialAccounts.Remove(socialAccount);
        }
    }
}