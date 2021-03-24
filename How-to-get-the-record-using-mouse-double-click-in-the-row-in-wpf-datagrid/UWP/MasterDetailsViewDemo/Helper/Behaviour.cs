using Microsoft.Xaml.Interactivity;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
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
            this.dataGrid.DoubleTapped += DataGrid_DoubleTapped;
           this.dataGrid.DetailsViewLoading += dataGrid_DetailsViewLoading;
            this.dataGrid.DetailsViewUnloading += dataGrid_DetailsViewUnloading;
            
        }

       

        private async void DataGrid_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
          
           var visualcontainer = this.dataGrid.GetVisualContainer();
           // get the row and column index based on the pointer position in UWP 
            var point = e.GetPosition(Window.Current.Content);
           
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(point);
            
            if (rowColumnIndex.IsEmpty)
                return;
            var colindex = this.dataGrid.ResolveToGridVisibleColumnIndex(rowColumnIndex.ColumnIndex);
            if (colindex < 0 || colindex >= this.dataGrid.Columns.Count)
                return;
            var recordindex = this.dataGrid.ResolveToRecordIndex(rowColumnIndex.RowIndex);

            if (recordindex < 0)
                return;

            var recordentry = this.dataGrid.View.GroupDescriptions.Count == 0 ? this.dataGrid.View.Records[recordindex] : this.dataGrid.View.TopLevelGroup.DisplayElements[recordindex];

            //Returns if caption summary or group summary row encountered.
            if (!recordentry.IsRecords)
                return;

            object value = null;

            if (!this.dataGrid.IsInDetailsViewIndex(rowColumnIndex.RowIndex))
            {
                var record = (recordentry as RecordEntry).Data;
                value = record.GetType().GetProperty(dataGrid.Columns[colindex].MappingName).GetValue(record) ?? string.Empty;
                var dialog = new MessageDialog("Cell Value : " + value.ToString());
                await dialog.ShowAsync();
               
            }
        }



        void dataGrid_DetailsViewUnloading(object sender, Syncfusion.UI.Xaml.Grid.DetailsViewLoadingAndUnloadingEventArgs e)
        {
            e.DetailsViewDataGrid.DoubleTapped-= DetailsViewDataGrid_DoubleTapped;
        }

       

        void dataGrid_DetailsViewLoading(object sender, Syncfusion.UI.Xaml.Grid.DetailsViewLoadingAndUnloadingEventArgs e)
        {
            e.DetailsViewDataGrid.DoubleTapped += DetailsViewDataGrid_DoubleTapped;
        
        }

        private async void DetailsViewDataGrid_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            var detailsViewDataGrid = sender as DetailsViewDataGrid;
            //Here you can get the DetailsViewDataGridVisualContainer.
            var detailsViewVisualContainer = detailsViewDataGrid.GetVisualContainer();
            //Here you can get the rowColumnIndex based on position of DetailsViewDataGridVisualContainer.
            var detailsViewRowColumnIndex = detailsViewVisualContainer.PointToCellRowColumnIndex(e.GetPosition(detailsViewVisualContainer), true);
            var detailsViewrecordIndex = detailsViewDataGrid.ResolveToRecordIndex(detailsViewRowColumnIndex.RowIndex);
            var detailsViewRecordEntry = detailsViewDataGrid.View.GroupDescriptions.Count == 0 ? detailsViewDataGrid.View.Records[detailsViewrecordIndex] : detailsViewDataGrid.View.TopLevelGroup.DisplayElements[detailsViewrecordIndex];
            //Returns if caption summary or group summary row encountered.
            if (!detailsViewRecordEntry.IsRecords)
                return;
            var record = (detailsViewRecordEntry as RecordEntry).Data;

            var value = record.GetType().GetProperty(detailsViewDataGrid.Columns[detailsViewRowColumnIndex.ColumnIndex].MappingName).GetValue(record) ?? string.Empty;
            var dialog = new MessageDialog("Cell Value : " + value.ToString());
            await dialog.ShowAsync();
        }

        protected override void OnDetaching()
        {
            this.dataGrid.DoubleTapped -= DataGrid_DoubleTapped;
            this.dataGrid.DetailsViewLoading -= dataGrid_DetailsViewLoading;
            this.dataGrid.DetailsViewUnloading -= dataGrid_DetailsViewUnloading;
        }
    }
}

