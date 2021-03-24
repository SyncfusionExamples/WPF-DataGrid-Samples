using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo.Helpers
{
    public class CommandHandler : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged;

        public CommandHandler(Action<object> execute)
            : this(execute, DefaultCanExecute)
        {
        }
        public CommandHandler(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        private static bool DefaultCanExecute(object parameter)
        {
            return true;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute != null && this.canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
