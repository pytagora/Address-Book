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
        private List<Residence> residences = new List<Residence>();
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
            residences = new List<Residence>();
            socialAccounts = new List<SocialAccount>();
        }
        public Contact(string name, Email email)
        {
            FirstName = name;
            emails = new List<Email>();
            phones = new List<Phone>();
            residences = new List<Residence>();
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
        public void AddNumber(Phone phone)
        {
            phones.Add(phone);
        }
        public void RemoveNumber(Phone phone)
        {
            phones.Remove(phone);
        }
        public void ChangePhone(Phone phone, int i)
        {
            phones[i] = phone;
        }
        public void AddResidence(Residence residence)
        {
            residences.Add(residence);
        }
        public void RemoveResidence(Residence residence)
        {
            residences.Remove(residence);
        }
        public void ChangeResidence(Residence residence, int i)
        {
            residences[i] = residence;
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
    }
}