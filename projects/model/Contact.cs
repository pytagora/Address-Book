﻿using System.Collections.Generic;
using System.ComponentModel;
using FluentValidation;

namespace Model
{
    public class Contact : INotifyPropertyChanged
    {   
        private readonly List<Email> _emails = new List<Email>();
        private readonly List<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();
        private readonly List<Address> _addresses = new List<Address>();
        private readonly List<SocialAccount> _socialAccounts = new List<SocialAccount>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private int _id;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _birthPlace = string.Empty;
        //public DateTime BirthDay { get; set; }
        private string _gender = string.Empty;
        private string _comment = string.Empty;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            } 
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(FirstName);
                OnPropertyChanged(FullName);
            } 
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(LastName);
                OnPropertyChanged(FullName);
            }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string BirthPlace
        {
            get => _birthPlace;
            set
            {
                _birthPlace = value;
                OnPropertyChanged(BirthPlace);
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(Gender);
            }
        }

        public string Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(Comment);
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
            return _addresses;
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
            _addresses.Add(addreess);
        }

        public void RemoveAddress(Address addreess)
        {
            _addresses.Remove(addreess);
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