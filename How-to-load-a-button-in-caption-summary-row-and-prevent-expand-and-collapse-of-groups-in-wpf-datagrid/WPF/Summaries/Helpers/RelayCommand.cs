using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SummariesDemo
{
    public class RelayCommand<T> : ICommand
    {
        #region Fields

        readonly Action<T> _execute = null;

        readonly Predicate<T> _canExecute = null;

        #endregion // Fields
        #region Constructors

        public RelayCommand(Action<T> execute)

            : this(execute, null)
        {

        }

        /// <summary>

        /// Creates a new command.

        /// </summary>

        /// <param name="execute">The execution logic.</param>

        /// <param name="canExecute">The execution status logic.</param>

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null)

                throw new ArgumentNullException("execute");

            _execute = execute;

            _canExecute
         = canExecute;

        }


        #endregion 
        #region ICommand Members


        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);

        }

        public event EventHandler CanExecuteChanged
        {

            add
            { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }

        public void Execute(object parameter)
        {


            _execute((T)parameter);

        }

        #endregion 

    }
}
