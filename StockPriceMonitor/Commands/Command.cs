using System;
using System.Windows.Input;

namespace StockPriceMonitor.Commands
{
    internal class Command : ICommand
    {
        private Predicate<object> _canExecute;
        private Action<object> _execute;

        public Command(Predicate<object> canExecute, Action<object> execute)
        {
            if (canExecute == null || execute == null)
            {
                throw new ArgumentNullException("Argument cannot be null");
            }

            _canExecute = canExecute;
            _execute = execute;
        }


        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
