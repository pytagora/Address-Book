using System.Collections.ObjectModel;
using Model;

namespace ViewModel
{
    public class ContactViewModel 
    {
        public MyICommand DeleteCommand { get; set; }

        public ContactViewModel()
        {
            LoadContacts();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }
        public ObservableCollection<Contact> Contacts { get; set; }

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
            get { return _selectedContact; }
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
    }
}