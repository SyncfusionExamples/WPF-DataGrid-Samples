using Syncfusion.UI.Xaml.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo
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

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        #endregion
        #region ICommand Members


        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);

        }
        public void Execute(object parameter)
        {


            _execute((T)parameter);

        }

        bool ICommand.CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        void ICommand.Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
