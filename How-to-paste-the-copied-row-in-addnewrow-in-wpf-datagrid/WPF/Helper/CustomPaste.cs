using Syncfusion.Data;
using Syncfusion.Data.Helper;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Syncfusion.Data.Extensions;

namespace SfDataGridDemo
{
    public class CustomPaste : GridCutCopyPaste
    {
        public CustomPaste(SfDataGrid sfgrid)
            : base(sfgrid)
        {

        }

        protected override void PasteTextToRow()
        {
            IDataObject dataObject = null;
            dataObject = Clipboard.GetDataObject();
            var clipBoardContent = dataObject.GetData(DataFormats.UnicodeText) as string;
            string[] records = Regex.Split(clipBoardContent.ToString(), @"\r\n");
            if (dataGrid.SelectionUnit == GridSelectionUnit.Row)
            {
                dataGrid.Focus();
                bool isAddNewRow = this.dataGrid.IsAddNewIndex(this.dataGrid.SelectionController.CurrentCellManager.CurrentRowColumnIndex.RowIndex);
               
                //Checking for row is AddNewRow.
                if (isAddNewRow)
                {
                    if (!this.dataGrid.View.IsAddingNew)
                        return;
                                      
                    string[] record = Regex.Split(records[0], @"\t");
                    var provider = this.dataGrid.View.GetPropertyAccessProvider();                  
                    var rowData = (this.dataGrid.View as CollectionViewAdv).CurrentAddItem;

                    //Paste the copied row in each cell.
                    foreach (var column in this.dataGrid.Columns)
                    {                       
                        var cellText = provider.GetValue(rowData, column.MappingName);
                        if (cellText == null)
                        {
                            PropertyDescriptorCollection typeInfos = this.dataGrid.View.GetItemProperties();
                            var typeInfo = typeInfos.GetPropertyDescriptor(column.MappingName);                          
                        }
                        CommitValue(rowData, column, provider, record[this.dataGrid.Columns.IndexOf(column)]);
                    }
                }
            }
            else
                base.PasteTextToRow();
        }
    }
}

