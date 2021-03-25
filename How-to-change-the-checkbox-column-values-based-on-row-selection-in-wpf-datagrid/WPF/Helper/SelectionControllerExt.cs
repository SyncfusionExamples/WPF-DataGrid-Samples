using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Utility;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.Windows.Shared;

namespace SfDataGridDemo
{

    public class RowSelectionController : GridSelectionController
    {
        public RowSelectionController(SfDataGrid dataGrid)
            : base(dataGrid)
        { }

        protected override void ProcessPointerReleased(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
        {
            base.ProcessPointerReleased(args, rowColumnIndex);
            CheckBoxSelection(rowColumnIndex);
            args.Handled = true;
            DataGrid.Focus();
        }

        protected override void ProcessKeyDown(KeyEventArgs args)
        {
            base.ProcessKeyDown(args);
            if (args.Key == Key.Space)
                CheckBoxSelection(this.CurrentCellManager.CurrentRowColumnIndex);
        }

        private void CheckBoxSelection(RowColumnIndex rowcolumnIndex)
        {
            var selectedrow = this.SelectedRows.FindAll(item => item.RowIndex == rowcolumnIndex.RowIndex);
            if (selectedrow.Count == 0)
            {
                var row = this.DataGrid.GetRecordAtRowIndex(rowcolumnIndex.RowIndex);
                (row as OrderInfo).IsSelected = false;
            }
            else
                (selectedrow[0].RowData as OrderInfo).IsSelected = true;
            var collectioncount = (DataGrid.DataContext as ViewModel).OrderInfoCollection.Count;
            var selecteditemcount = DataGrid.SelectedItems.Count;
            if (selecteditemcount == collectioncount)
                (this.DataGrid.DataContext as ViewModel).IsSelectAll = true;
            else if (selecteditemcount == 0)
                (this.DataGrid.DataContext as ViewModel).IsSelectAll = false;
            else
                (this.DataGrid.DataContext as ViewModel).IsSelectAll = null;
        }
    }
}
