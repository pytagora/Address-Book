using System;
using System.Collections.Generic;

namespace Model
{
    public class Contact
    {
        private readonly List<Email> _emails;
        private readonly List<Phone> _phones;
        private readonly List<Addreess> _addreesses;
        private readonly List<SocialAccount> _socialAccounts;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthPlace { get; set; }

        public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string Comment { get; set; }

        public Contact()
        {
            _emails = new List<Email>();
            _phones = new List<Phone>();
            _addreesses = new List<Addreess>();
            _socialAccounts = new List<SocialAccount>();
        }
        public Contact(string firstName, Email email)
        {
            FirstName = firstName;
            _emails = new List<Email>();
            _phones = new List<Phone>();
            _addreesses = new List<Addreess>();
            _socialAccounts = new List<SocialAccount>();

            AddEmail(email);
        }
        public void AddEmail(Email email)
        {
            _emails.Add(email);
        }
        public void RemoveEmail(Email email)
        {
            _emails.Remove(email);
        }
        public IEnumerable<Email> GetEmails()
        {
            return _emails;
        }
        public IEnumerable<Phone> GetPhones()
        {
            return _phones;
        }
        public IEnumerable<SocialAccount> GetSocialAccounts()
        {
            return _socialAccounts;
        }
        public IEnumerable<Addreess> GetAddreesses()
        {
            return _addreesses;
        }
        public void AddNumber(Phone phone)
        {
            _phones.Add(phone);
        }
        public void RemoveNumber(Phone phone)
        {
            _phones.Remove(phone);
        }
        public void AddAddress(Addreess addreess)
        {
            _addreesses.Add(addreess);
        }
        public void RemoveAddress(Addreess addreess)
        {
            _addreesses.Remove(addreess);
        }
        public void AddSocialAccount(SocialAccount socialAccount)
        {
            _socialAccounts.Add(socialAccount);
        }
        public void RemoveSocialAccount(SocialAccount socialAccount)
        {
            _socialAccounts.Remove(socialAccount);
        }
    }
}