using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace SfDataGrid_CopyPaste
{
    public class CustomCopyPaste : GridCutCopyPaste
    {
        public CustomCopyPaste(SfDataGrid sfgrid)
            : base(sfgrid)
        {
        }

        protected override void PasteToRow(object clipboardcontent, object selectedRecords)
        {
            if (dataGrid.SelectionUnit == GridSelectionUnit.Row)
                base.PasteToRow(clipboardcontent, selectedRecords);
            else
            {
                //Get the copied value.
                clipboardcontent = Regex.Split(clipboardcontent.ToString(), @"\t");
                var copyValue = (string[])clipboardcontent;

                int cellcount = copyValue.Count();
                var selectionContoller = this.dataGrid.SelectionController as GridCellSelectionController;
                var lastselectedindex = selectionContoller.CurrentCellManager.CurrentRowColumnIndex.ColumnIndex;
                var Propertyinfo = (this.dataGrid.SelectionController as GridCellSelectionController).GetType().GetProperty("PressedRowColumnIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                var pressedrowcolumnindex = Propertyinfo.GetValue(this.dataGrid.SelectionController);
                var pressedindex = ((RowColumnIndex)(pressedrowcolumnindex)).ColumnIndex;
                var pastecolumnindex = pressedindex < lastselectedindex ? pressedindex : lastselectedindex;

                int columnindex = 0;
                var columnStartIndex = this.dataGrid.ResolveToGridVisibleColumnIndex(pastecolumnindex);
                for (int i = columnStartIndex; i < cellcount + columnStartIndex; i++)
                {
                    if (dataGrid.GridPasteOption.HasFlag(GridPasteOption.IncludeHiddenColumn))
                    {
                        if (dataGrid.Columns.Count <= i)
                            break;
                        PasteToCell(selectedRecords, dataGrid.Columns[i], copyValue[columnindex]);
                        columnindex++;
                    }
                    else
                    {
                        if (dataGrid.Columns.Count <= i)
                            break;
                        //Paste the copied value here include empty string value.
                        if (!dataGrid.Columns[i].IsHidden)
                        {
                            PasteToCell(selectedRecords, dataGrid.Columns[i], copyValue[columnindex]);
                            columnindex++;
                        }
                        else
                            cellcount++;
                    }
                }
            }
        }
    }
}
    
