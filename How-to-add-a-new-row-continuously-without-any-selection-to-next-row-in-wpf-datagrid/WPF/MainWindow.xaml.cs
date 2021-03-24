using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.ScrollAxis;
using System.Windows.Threading;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void datagrid_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs args)
        {
            //Skip the selection moved to next row when adding new row.        
            bool needToMove = (dataGrid.IsAddNewIndex(args.PreviousRowColumnIndex.RowIndex)
                && !dataGrid.IsAddNewIndex(args.CurrentRowColumnIndex.RowIndex)
                && (Keyboard.IsKeyDown(Key.Enter) || Keyboard.IsKeyDown(Key.Tab)));
            Dispatcher.BeginInvoke(new Action(() =>
            {
                var gridModel = this.dataGrid.GetGridModel();
                var columnIndex = this.dataGrid.GetFirstColumnIndex();
                if (needToMove && gridModel != null)
                {
                    this.dataGrid.MoveCurrentCell(new RowColumnIndex(gridModel.AddNewRowController.GetAddNewRowIndex(), columnIndex));
                }
            }), DispatcherPriority.ApplicationIdle);
        }             
    }
}
         
   

