using Microsoft.Xaml.Interactivity;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace MasterDetailsViewDemo
{
    public class Behaviour : Behavior<SfDataGrid>
    {
        SfDataGrid dataGrid;
        protected override void OnAttached()
        {
            dataGrid = this.AssociatedObject as SfDataGrid;
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
                detailsViewDataGrid.Background = new SolidColorBrush(Windows.UI.Colors.LightBlue);
            }
                if (e.AddedItems.Count > 0)
            {
                var rowIndex = (e.AddedItems[0] as GridRowInfo).RowIndex;
                var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(this.dataGrid.ResolveToRecordIndex(rowIndex), "OrderDetails");
                if (detailsViewDataGrid == null)
                    return;
                detailsViewDataGrid.Background = new SolidColorBrush(Windows.UI.Colors.LightGreen);
            }
        }
    }
    public class BackGroundConverter : IValueConverter
    {

        public object Convert(object value, System.Type targetType, object parameter, string culture)
        {
            return new SolidColorBrush(Colors.DarkGray);
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, string culture)
        {
            return null;
        }

       
    }
}
