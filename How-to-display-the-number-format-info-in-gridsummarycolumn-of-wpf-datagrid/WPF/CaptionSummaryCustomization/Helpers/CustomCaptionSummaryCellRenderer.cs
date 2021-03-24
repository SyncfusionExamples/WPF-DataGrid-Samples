using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CaptionSummaryCustomization
{
    public class CustomCaptionSummaryCellRenderer : GridCaptionSummaryCellRenderer
    {
        // Method to initialize the CaptionSummaryCell.

        public override void OnInitializeEditElement(DataColumnBase dataColumn, GridCaptionSummaryCell uiElement, object dataContext)
        {
            GridColumn column = dataColumn.GridColumn;

            if (dataContext is Group)
            {
                var groupRecord = dataContext as Group;
                if (this.DataGrid.CaptionSummaryRow == null)
                {
                    // get the column which is grouped
                    var groupedColumn = this.GetGroupedColumn(groupRecord);
                    //set the captionsummarycell text as customized.
                    uiElement.Content = GetCustomizedCaptionText(groupedColumn.HeaderText, groupRecord.Key,
                        groupRecord.ItemsCount);
                }
                else if (this.DataGrid.CaptionSummaryRow.ShowSummaryInRow)
                {
                    uiElement.Content = SummaryCreator.GetSummaryDisplayTextForRow(groupRecord.SummaryDetails,
                        this.DataGrid.View);
                }
                else
                    uiElement.Content = SummaryCreator.GetSummaryDisplayText(groupRecord.SummaryDetails,
                        column.MappingName, this.DataGrid.View);
            }
        }

        // Method to update the CaptionSummaryCell

        public override void OnUpdateEditBinding(DataColumnBase dataColumn, GridCaptionSummaryCell element, object dataContext)
        {
            GridColumn column = dataColumn.GridColumn;

            if (element.DataContext is Group && this.DataGrid.View.GroupDescriptions.Count > 0)
            {
                var groupRecord = element.DataContext as Group;
                //get the column which is grouped.
                var groupedColumn = this.GetGroupedColumn(groupRecord);
                if (this.DataGrid.CaptionSummaryRow == null)
                {
                    if (this.DataGrid.View.GroupDescriptions.Count < groupRecord.Level)
                        return;
                    //set the captionsummary text as customized.
                    element.Content = GetCustomizedCaptionText(groupedColumn.HeaderText, groupRecord.Key,
                        groupRecord.ItemsCount);
                }
                else if (this.DataGrid.CaptionSummaryRow.ShowSummaryInRow)
                {
                    element.Content = SummaryCreator.GetSummaryDisplayTextForRow(groupRecord.SummaryDetails,
                        this.DataGrid.View, groupedColumn.HeaderText);
                }
                else
                    element.Content = SummaryCreator.GetSummaryDisplayText(groupRecord.SummaryDetails,
                        column.MappingName, this.DataGrid.View);
            }
        }

        // Method to get the Grouped Column.
        private GridColumn GetGroupedColumn(Group group)
        {
            var groupDesc = this.DataGrid.View.GroupDescriptions[group.Level - 1] as PropertyGroupDescription;
            foreach (var column in this.DataGrid.Columns)
            {
                if (column.MappingName == groupDesc.PropertyName)
                {
                    return column;
                }
            }
            return null;
        }     

        // Method to Customize the CaptionSummaryCell Text.
        private string GetCustomizedCaptionText(string columnName, object groupName, int itemsCount)
        {
            //entryText - instead of "Items", the entryText is assigned to Customize the CaptionSummaryCell Text.

            groupName = GetNumberFormatInfo(groupName,columnName);

            string entryText = "Items";

            return string.Format("{0}: {1} - {2} {3}", columnName, groupName, itemsCount, entryText);
        }

        private string GetNumberFormatInfo(object value, string columnName)
        {
            if (columnName == "EmployeeSalary")
            {
                //based on the column name, you can set the NumberFormatInfo to the summary columns.
                var cultureName = CultureInfo.CurrentCulture.Name;
                NumberFormatInfo nfi = new CultureInfo(cultureName, false).NumberFormat;
                double formatedNumber = (double)value;
                nfi.NumberDecimalDigits = 2;
                int[] mySizes = { 2, 3, 0 };
                nfi.NumberGroupSizes = mySizes;
                nfi.NumberGroupSeparator = ",,";
                nfi.NumberDecimalSeparator = "..";

                var content = formatedNumber.ToString("N", nfi);
                return content;
            }
            return value.ToString();
        }
    }
}


