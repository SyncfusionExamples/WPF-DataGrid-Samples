using Microsoft.Xaml.Interactivity;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SfDataGridDemo
{
    class SfDataGridBehavior :Behavior<SfDataGrid>
    {
        SfDataGrid dataGrid = null;
        ToolTip toolTip = new ToolTip();
        RowColumnIndex rowColumnIndex = new RowColumnIndex();

        protected override void OnAttached()
        {
            dataGrid = this.AssociatedObject as SfDataGrid;
            dataGrid.PointerMoved += DataGrid_PointerMoved;
        }

        private void DataGrid_PointerMoved(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            var visualContainer = dataGrid.GetVisualContainer();
            var point = e.GetCurrentPoint(visualContainer).Position;
            var rowcolumnindex = visualContainer.PointToCellRowColumnIndex(point);
            var rowindex = rowcolumnindex.RowIndex;
            if(rowindex != rowColumnIndex.RowIndex)
                toolTip.IsOpen = false;
            var columnindex = rowcolumnindex.ColumnIndex;
            rowColumnIndex = rowcolumnindex;
            // Get the resolved current record index
            var recordIndex = this.dataGrid.ResolveToRecordIndex(rowindex);

            if (rowindex == 2 && columnindex == 1) // EmployeeName
            {
                // Get the current row record
                var mappingName = this.dataGrid.Columns[columnindex].MappingName;
                var record = this.dataGrid.View.Records.GetItemAt(recordIndex);
                var cellvalue = record.GetType().GetProperty(mappingName).GetValue(record, null).ToString();
                toolTip.Content = cellvalue;
                var dataColumnBase = SelectionHelper.GetDataColumnBase(this.dataGrid, new Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex(rowindex,columnindex));
                if (dataColumnBase != null)
                {
                    GridCell gridCell = dataColumnBase.ColumnElement as GridCell;
                    if (gridCell != null)
                    {
                        ToolTipService.SetToolTip(gridCell, toolTip);
                        toolTip.IsOpen = true;
                    }
                }
            }
        }
    }
}
