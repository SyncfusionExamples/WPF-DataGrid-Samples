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
        

        protected override void OnAttached()
        {
            dataGrid = this.AssociatedObject as SfDataGrid;
            dataGrid.RowValidating += DataGrid_RowValidating;
            dataGrid.PasteGridCellContent += DataGrid_PasteGridCellContent;
        }

        private void DataGrid_RowValidating(object sender, RowValidatingEventArgs e)
        {
            var employee = e.RowData as Employee;
            if (employee.EmployeeName == "Null" || employee.EmployeeName == "DbNull")
            {
                e.IsValid = false;
                e.ErrorMessages.Add("EmployeeName", "EmployeeName must have a value and it should not be null");
            }
        }

        private void DataGrid_PasteGridCellContent(object sender, GridCopyPasteCellEventArgs e)
        {
            this.dataGrid.GetValidationHelper().SetCurrentRowValidated(false);
        }
    }
}
