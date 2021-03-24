using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public class GridSelectionControllerExt : GridSelectionController
    {
        SfDataGrid datagrid;
        public GridSelectionControllerExt(SfDataGrid dataGrid): base(dataGrid)
        {
            datagrid = dataGrid;
        }

        /// <summary>
        /// Processes the row selection when the mouse pointer is released from SfDataGrid. 
        /// </summary>
        /// <param name="args">
        /// Contains the data for mouse pointer action.
        /// </param>
        /// <param name="rowColumnIndex">
        /// The corresponding rowColumnIndex of the mouse released point.
        /// </param>
        /// <remarks>
        /// The selection is initialized in pointer released state when the <see cref="Syncfusion.UI.Xaml.Grid.SfDataGrid.AllowSelectionPointerPressed"/> set as false.        
        /// </remarks>
        protected override void ProcessPointerReleased(MouseButtonEventArgs args, Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex rowColumnIndex)
        {
            if (SelectionHelper.CheckShiftKeyPressed() && this.PressedRowColumnIndex.RowIndex > 0)
            {
                this.SelectRows(this.PressedRowColumnIndex.RowIndex, rowColumnIndex.RowIndex);
            }
            else
                base.ProcessPointerReleased(args, rowColumnIndex);
        }

        /// <summary>
        /// Selects the rows corresponding to the specified start and end index of the row.
        /// </summary>
        /// <param name="startRowIndex">
        /// The start index of the row.
        /// </param>
        /// <param name="endRowIndex">
        /// The end index of the row.
        /// </param>
        public override void SelectRows(int startRowIndex, int endRowIndex)
        {
            if (startRowIndex < 0 || endRowIndex < 0)
                return;

            if (startRowIndex > endRowIndex)
            {
                var temp = startRowIndex;
                startRowIndex = endRowIndex;
                endRowIndex = temp;
            }

            if (this.DataGrid.SelectionMode == GridSelectionMode.None ||
                this.DataGrid.SelectionMode == GridSelectionMode.Single)
                return;

            var isSelectedRowsContains = this.SelectedRows.Any();

            this.SuspendUpdates();
            var addedItem = new List<object>();
            int rowIndex = startRowIndex;

            this.datagrid.SelectedItems.Clear();
            var rowIndexes = this.datagrid.SelectionController.SelectedRows.Select(rowinfo => rowinfo.RowIndex).ToList(); 

            var selectedrowindex = this.datagrid.ResolveToRowIndex(this.datagrid.SelectedIndex);


            for (int i = rowIndex; i <= endRowIndex; i++)
            {
                object rowData = this.DataGrid.GetRecordAtRowIndex(i);

                if (!rowIndexes.Contains(i))
                {
                    this.SelectedRows.Add(GetGridSelectedRow(i));
                    this.DataGrid.ShowRowSelection(i);
                }
                if (rowData != null)
                {
                    this.DataGrid.SelectedItems.Add(rowData);
                }
            }

            if (!isSelectedRowsContains)
            {
                this.DataGrid.SelectedIndex = this.SelectedRows.Count > 0 ? this.DataGrid.ResolveToRecordIndex(this.SelectedRows[0].RowIndex) : -1;
                this.DataGrid.SelectedItem = this.DataGrid.SelectedItems.Count > 0 ? this.DataGrid.SelectedItems[0] : null;

            }
            this.ResumeUpdates();
        }
    }
}
