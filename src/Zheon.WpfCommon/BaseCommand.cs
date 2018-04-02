using System;
using System.Windows.Input;

namespace Zheon.WpfCommon
{
    public abstract class BaseCommand : ICommand
    {
        private bool _canExecute;

        protected BaseCommand()
        {
            _canExecute = true;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var canExecute = OnCanExecute(parameter);
            if (canExecute != _canExecute)
            {
                _canExecute = canExecute;
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }

            return _canExecute;
        }

        public void Execute(object parameter)
        {
            OnExecute(parameter);
        }

        public virtual bool OnCanExecute(object parameter)
        {
            return true;
        }

        public abstract void OnExecute(object parameter);
    }
}