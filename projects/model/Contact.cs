using System.Collections.Generic;
using System.ComponentModel;
using FluentValidation;

namespace Model
{
    public class Contact : INotifyPropertyChanged
    {   
        private readonly List<Email> _emails;
        private readonly List<PhoneNumber> _phoneNumbers;
        private readonly List<Address> _addreesses;
        private readonly List<SocialAccount> _socialAccounts;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        //public DateTime BirthDay { get; set; }
        private string _gender;
        private string _comment;

        public Contact()
        {
        }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            } 
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            } 
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        public string BirthPlace
        {
            get => _birthPlace;
            set
            {
                _birthPlace = value;
                OnPropertyChanged("BirthPlace");
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }

        public string Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged("Comment");
            }
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