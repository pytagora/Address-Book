using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Contact
    {
        private readonly string Name = string.Empty;
        private List<Email> emails = null;
        private List<Phone> numbers = null;
        private List<Residence> addresses = null;
        private List<SocialAccount> socialAccounts = null;

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
            numbers = new List<Phone>();
            addresses = new List<Residence>();
            socialAccounts = new List<SocialAccount>();
        }
        public Contact(string name, Email email)
        {
            FirstName = name;
            emails = new List<Email>();
            numbers = new List<Phone>();
            addresses = new List<Residence>();
            socialAccounts = new List<SocialAccount>();

            //this.AddEmail(email);
        }
        /*public void AddEmail(Email email)
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
        }*/
    }
}