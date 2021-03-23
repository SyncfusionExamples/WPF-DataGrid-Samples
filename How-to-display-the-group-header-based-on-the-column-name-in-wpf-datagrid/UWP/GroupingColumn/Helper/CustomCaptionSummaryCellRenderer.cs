using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class CustomCaptionSummaryCellRenderer : GridCaptionSummaryCellRenderer
    {
        /// <summary>
        /// Method to initialize the CaptionSummaryCell.
        /// </summary>
        public override void OnInitializeEditElement(DataColumnBase dataColumn, GridCaptionSummaryCell uiElement, object dataContext)
        {
            if (dataContext is Group)
            {
                string groupName = string.Empty;
                var groupRecord = dataContext as Group;
                if (this.DataGrid.CaptionSummaryRow == null)
                {
                    // get the column which is grouped
                    var groupedColumn = this.GetGroupedColumn(groupRecord);
                    //set the captionsummarycell text as customized.

                    var groupRecords = (groupRecord.Details as GroupRecordEntry).Records;
                    var groupData = (groupRecords[0] as RecordEntry).Data;

                    if (groupedColumn.MappingName == "EmployeeID")
                        groupName = (groupData as BusinessObject).EmployeeName;
                    else
                        groupName = groupRecord.Key.ToString();

                    uiElement.Content = GetCustomizedCaptionText(groupedColumn.HeaderText, groupName, groupRecord.ItemsCount);
                }
                else if (this.DataGrid.CaptionSummaryRow.ShowSummaryInRow)
                {
                    uiElement.Content = SummaryCreator.GetSummaryDisplayTextForRow(groupRecord.SummaryDetails, this.DataGrid.View);
                }
                else
                    uiElement.Content = SummaryCreator.GetSummaryDisplayText(groupRecord.SummaryDetails, dataColumn.GridColumn.MappingName, this.DataGrid.View);
            }
        }
        /// <summary>
        /// Method to update the CaptionSummaryCell
        /// </summary>
        public override void OnUpdateEditBinding(DataColumnBase dataColumn, GridCaptionSummaryCell element, object dataContext)
        {
            if (element.DataContext is Group && this.DataGrid.View.GroupDescriptions.Count > 0)
            {
                string groupName = string.Empty;
                string groupText = string.Empty;
                var groupRecord = element.DataContext as Group;
                //get the column which is grouped.
                var groupedColumn = this.GetGroupedColumn(groupRecord);

                var groupRecords = (groupRecord.Details as GroupRecordEntry).Records;
                var groupData = (groupRecords[0] as RecordEntry).Data;

                if (groupedColumn.MappingName == "EmployeeID")
                {
                    groupName = (groupData as BusinessObject).EmployeeName;
                    groupText = "Employee Name";
                }
                else
                {
                    groupName = groupRecord.Key.ToString();
                    groupText = groupedColumn.HeaderText;
                }
                if (this.DataGrid.CaptionSummaryRow == null)
                {
                    if (this.DataGrid.View.GroupDescriptions.Count < groupRecord.Level)
                        return;
                    //set the captionsummary text as customized.
                    element.Content = GetCustomizedCaptionText(groupText, groupName, groupRecord.ItemsCount);
                }
                else if (this.DataGrid.CaptionSummaryRow.ShowSummaryInRow)
                {
                    element.Content = SummaryCreator.GetSummaryDisplayTextForRow(groupRecord.SummaryDetails, this.DataGrid.View, groupedColumn.HeaderText);
                }
                else
                    element.Content = SummaryCreator.GetSummaryDisplayText(groupRecord.SummaryDetails, dataColumn.GridColumn.MappingName, this.DataGrid.View);
            }
        }


        /// <summary>
        /// Method to get the Grouped Column.
        /// </summary>
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

        /// <summary>
        /// Method to Customize the CaptionSummaryCell Text.
        /// </summary>
        private string GetCustomizedCaptionText(string columnName, object groupName, int itemsCount)
        {
            //entryText - instead of "Items", the entryText is assigned to Customize the CaptionSummaryCell Text.
            string entryText = string.Empty;

            if (itemsCount < 20)
                entryText = "entries in the Group";
            else if (itemsCount < 40)
                entryText = "elements in the Group";
            else if (itemsCount < 60)
                entryText = "list in the Group";
            else
                entryText = "items in the Group";

            if (groupName.ToString().Equals("1000"))
                groupName = "One Thousand";
            else if (groupName.ToString().Equals("1002"))
                groupName = "Thousand and Two";
            else if (groupName.ToString().Equals("1004"))
                groupName = "Thousand and Four";

            return string.Format("{0}: {1} - {2} {3}", columnName, groupName, itemsCount, entryText);
        }
    }
}
