using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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

        public ContactViewModel()
        {
            LoadContacts();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}