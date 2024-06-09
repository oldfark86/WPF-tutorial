using System;
using System.Windows.Input;

namespace Wpf_tut23_Using_VIewModels_in_NVVM.NVVM
{
    internal class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object,bool> canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> excute, Func<object,bool> canExecute = null)
        {
            this.execute = excute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
}
