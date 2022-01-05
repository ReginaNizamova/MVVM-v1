using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace ControlStudy.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Action<object> execute;
        private Func<object, bool> canExecute;
        private Frame _frame;
        private DataGrid _dataGrid;

        public Frame Frame 
        {
            get
            {
                return _frame;
            }

            set
            {
                _frame = value;
                OnPropertyChanged("Frame");
            }
        }

        public event EventHandler CanExecuteChanged 
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        protected virtual void OnPropertyChanged ([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public BaseViewModel()
        {

        }

        public BaseViewModel(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
             
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public DataGrid DataGrid
        {
            get
            {
                return _dataGrid;
            }

            set
            {
                _dataGrid = value;
                OnPropertyChanged("DataGrid");
            }
        }
    }
}
