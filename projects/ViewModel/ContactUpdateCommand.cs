using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    class ContactUpdateCommand : ICommand
    {
        public ContactUpdateCommand(ContactViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        private ContactViewModel _viewModel;

        #region ICommand Members

        public event  System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _viewModel.SaveChanges();
        }

#endregion
    }
}
