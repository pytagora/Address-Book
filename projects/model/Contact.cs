using System.Collections.Generic;

namespace Model
{
    public class Contact
    {
        private readonly List<Email> _emails;
        private readonly List<PhoneNumber> _phoneNumbers;
        private readonly List<Address> _addreesses;
        private readonly List<SocialAccount> _socialAccounts;

        public int Id = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthPlace { get; set; }
        //public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Comment { get; set; }

        public Contact()
        {
            ++Id;
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
        public IEnumerable<PhoneNumber> GetPhones()
        {
            return _phoneNumbers;
        }
        public IEnumerable<SocialAccount> GetSocialAccounts()
        {
            return _socialAccounts;
        }
        public IEnumerable<Address> GetAddreesses()
        {
            return _addreesses;
        }
        public void AddPhoneNumber(PhoneNumber phone)
        {
            _phoneNumbers.Add(phone);
        }
        public void RemovePhoneNumber(PhoneNumber phone)
        {
            _phoneNumbers.Remove(phone);
        }
        public void AddAddress(Address addreess)
        {
            _addreesses.Add(addreess);
        }
        public void RemoveAddress(Address addreess)
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