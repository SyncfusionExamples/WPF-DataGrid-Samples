using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Rowheight
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        GridRowSizingOptions gridRowResizingOptions = new GridRowSizingOptions();
        List<string> excludeColumns = new List<string>();
        double autoHeight = double.NaN;
        public MainPage()
        {
            this.InitializeComponent();
            this.datagrid.ItemsSourceChanged += Datagrid_ItemsSourceChanged;            
            this.datagrid.QueryRowHeight += Datagrid_QueryRowHeight;                                 
        }
        private void Datagrid_ItemsSourceChanged(object sender, GridItemsSourceChangedEventArgs e)
        {
            foreach (var column in this.datagrid.Columns)
                if (!column.MappingName.Equals("EmployeeName") )
                    excludeColumns.Add(column.MappingName);
            gridRowResizingOptions.ExcludeColumns = excludeColumns;
        }

        private void Datagrid_QueryRowHeight(object sender, Syncfusion.UI.Xaml.Grid.QueryRowHeightEventArgs e)
        {
            if (this.datagrid.IsTableSummaryIndex(e.RowIndex))
            {
                e.Height = 40;
                e.Handled = true;
            }
            else if (this.datagrid.GridColumnSizer.GetAutoRowHeight(e.RowIndex, gridRowResizingOptions, out autoHeight))
            {
                if (autoHeight > this.datagrid.RowHeight)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
                }
            }
        }
    }
}
