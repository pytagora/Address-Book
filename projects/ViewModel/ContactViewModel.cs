using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Windows.Input;
using Model;

namespace ViewModel
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        private Contact _contact;

        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                NotifyPropertyChanged("Contact");
            }
        }

        private ObservableCollection<Contact> _contacts;

        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                NotifyPropertyChanged("Contacts");
            }
        }

        public ContactViewModel()
        {
            Contact = new Contact();
            Contacts = new ObservableCollection<Contact>();
            LoadContacts();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
            UpdateCommand = new ContactUpdateCommand(this);
        }

        public MyICommand DeleteCommand { get; set; }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(AddExecute, CanAddExecute, false);
                }

                return _addCommand;
            }
        }

        private void AddExecute(object parameter)
        {
            Contacts.Add(Contact);
        }

        private bool CanAddExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Contact.FirstName) || string.IsNullOrEmpty(Contact.LastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LoadContacts()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            // TO DO!!
            // read contacts from json file or protobuf
            Contacts = contacts;
        }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnDelete()
        {
            Contacts.Remove(SelectedContact);
        }

        private bool CanDelete()
        {
            return SelectedContact != null;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} {1} was updated.", Contact.FirstName, Contact.LastName));
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public bool CanUpdate
        {
            get
            {
                if (Contact == null)
                    return false;

                return !String.IsNullOrWhiteSpace(Contact.FirstName);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}