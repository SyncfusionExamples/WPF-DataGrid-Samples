using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace SfDataGridDemo
{
    class SfDataGridBehavior :Behavior<SfDataGrid>
    {
        SfDataGrid dataGrid = null;
        ToolTip toolTip = new ToolTip();

        protected override void OnAttached()
        {
            dataGrid = this.AssociatedObject as SfDataGrid;
            dataGrid.MouseMove += DataGrid_MouseMove;
        }

        private void DataGrid_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var visualContainer = dataGrid.GetVisualContainer();
            var point = e.GetPosition(visualContainer);
            var rowcolumnindex = visualContainer.PointToCellRowColumnIndex(point);
            var rowindex = rowcolumnindex.RowIndex;
            var columnindex = rowcolumnindex.ColumnIndex;
            // Get the resolved current record index
            var recordIndex = this.dataGrid.ResolveToRecordIndex(rowindex);

            if (rowindex == 2 && columnindex == 1) // EmployeeName
            {
                if (toolTip.IsOpen)
                    return;
                // Get the current row record
                var mappingName = this.dataGrid.Columns[columnindex].MappingName;
                var record = this.dataGrid.View.Records.GetItemAt(recordIndex);
                var cellvalue = record.GetType().GetProperty(mappingName).GetValue(record,null).ToString();
                toolTip.Content = cellvalue;
                toolTip.IsOpen = true;
                toolTip.StaysOpen = true;
            }
            toolTip.IsOpen = false;
            toolTip.StaysOpen = false;
        }
    }
}
