using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace MasterDetailsViewDemo
{
    public class Behaviour : Behavior<Window>
    {
        SfDataGrid dataGrid;
        protected override void OnAttached()
        {
            var window = this.AssociatedObject;
            this.dataGrid = window.FindName("dataGrid") as SfDataGrid;
            this.dataGrid.SelectionChanged += DataGrid_SelectionChanged;
        }

        private void DataGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {
            if (e.RemovedItems.Count > 0)
            {
                var rowIndex = (e.RemovedItems[0] as GridRowInfo).RowIndex;
                var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(this.dataGrid.ResolveToRecordIndex(rowIndex), "OrderDetails");
                if (detailsViewDataGrid == null)
                    return;
                detailsViewDataGrid.Background = Brushes.LightBlue;
            }
            if (e.AddedItems.Count > 0)
            {
                var rowIndex = (e.AddedItems[0] as GridRowInfo).RowIndex;
                var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(this.dataGrid.ResolveToRecordIndex(rowIndex), "OrderDetails");
                if (detailsViewDataGrid == null)
                    return;
                detailsViewDataGrid.Background = Brushes.LightGreen;
            }
        }
    }
    public class BackGroundConverter : IValueConverter
    {

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return "DarkGray";
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
