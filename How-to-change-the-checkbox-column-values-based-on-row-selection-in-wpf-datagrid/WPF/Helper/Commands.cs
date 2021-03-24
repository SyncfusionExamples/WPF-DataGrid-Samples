using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public static class Commands
    {
        static Commands()
        {
            CommandManager.RegisterClassCommandBinding(typeof(CheckBox), new CommandBinding(CheckAndUnCheck, OnCheckUnCheckCommand, OnCanExecuteCheckAndUnCheck));
        }

        public static RoutedCommand CheckAndUnCheck = new RoutedCommand("CheckAndUnCheck", typeof(CheckBox));

        private static void OnCheckUnCheckCommand(object sender, ExecutedRoutedEventArgs args)
        {
            var sfdatagrid = (args.Parameter as SfDataGrid);
            var viewmodel = (sfdatagrid.DataContext as ViewModel);
            var checkbox = (sender as CheckBox).IsChecked;
            if (viewmodel != null)
            {
                if (checkbox == true)
                {
                    sfdatagrid.SelectAll();
                    foreach (var collection in viewmodel.OrderInfoCollection)
                    {
                        if (collection.IsSelected == false)
                            collection.IsSelected = true;
                    }
                }
                else if (checkbox == false)
                {
                    sfdatagrid.ClearSelections(false);
                    foreach (var collection in viewmodel.OrderInfoCollection)
                    {  
                        if (collection.IsSelected == true)
                            collection.IsSelected = false;
                    }
                }
            }
        }

        private static void OnCanExecuteCheckAndUnCheck(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = true;
        }     
    }
}
