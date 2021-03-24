using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;

namespace CheckBoxSelectAllRowSample
{
    public class RowSelectionController : GridSelectionController
    {
        public RowSelectionController(SfDataGrid dataGrid)
            : base(dataGrid)
        { }

        protected override void ProcessPointerReleased(PointerRoutedEventArgs args, RowColumnIndex rowColumnIndex)
        {
            base.ProcessPointerReleased(args, rowColumnIndex);
            CheckBoxSelection(rowColumnIndex);
            if (args != null)
            {
                args.Handled = true;
                DataGrid.Focus(Windows.UI.Xaml.FocusState.Programmatic);
            }
        }

        protected override void ProcessKeyDown(KeyRoutedEventArgs args)
        {
            base.ProcessKeyDown(args);
            if (args.Key == Windows.System.VirtualKey.Space)
                CheckBoxSelection(this.CurrentCellManager.CurrentRowColumnIndex);
        }

        private void CheckBoxSelection(RowColumnIndex rowcolumnIndex)
        {
            this.DataGrid.Focus(Windows.UI.Xaml.FocusState.Programmatic);
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
