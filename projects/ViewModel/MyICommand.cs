using System;
using System.Windows.Input;

namespace ViewModel
{
    public class MyICommand : ICommand
    {
        readonly Action _targetExecuteMethod;
        private readonly Func<bool> _TargetCanExecuteMethod;

        public MyICommand(Action executeMethod)
        {
            _targetExecuteMethod = executeMethod;
        }

        public MyICommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _targetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetCanExecuteMethod != null)
            {
                return true;
            }

            return false;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        void ICommand.Execute(object parameter)
        {
            _targetExecuteMethod?.Invoke();
        }
    }
}