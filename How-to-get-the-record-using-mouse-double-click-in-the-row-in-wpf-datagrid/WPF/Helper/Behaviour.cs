using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.Data;
using System.Windows;


namespace MasterDetailsViewDemo
{
    public class Behaviour:Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            this.AssociatedObject.MouseDoubleClick += AssociatedObject_MouseDoubleClick;
            this.AssociatedObject.DetailsViewLoading += AssociatedObject_DetailsViewLoading;
            this.AssociatedObject.DetailsViewUnloading += AssociatedObject_DetailsViewUnloading;
        }

        void AssociatedObject_DetailsViewUnloading(object sender, Syncfusion.UI.Xaml.Grid.DetailsViewLoadingAndUnloadingEventArgs e)
        {
            e.DetailsViewDataGrid.MouseDoubleClick -= detailsViewDataGrid_MouseDoubleClick;
        }      

        void detailsViewDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
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
            MessageBox.Show("Cell Value : " + value.ToString());
        }

        void AssociatedObject_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var visualcontainer = this.AssociatedObject.GetVisualContainer();
            // get the row and column index based on the pointer position in WPF
            var rowColumnIndex = visualcontainer.PointToCellRowColumnIndex(e.GetPosition(visualcontainer));
            if (rowColumnIndex.IsEmpty)
                return;
            var colindex = this.AssociatedObject.ResolveToGridVisibleColumnIndex(rowColumnIndex.ColumnIndex);
            if (colindex < 0 || colindex >= this.AssociatedObject.Columns.Count)
                return;

            var recordindex = this.AssociatedObject.ResolveToRecordIndex(rowColumnIndex.RowIndex);
            if (recordindex < 0)
                return;

            var recordentry = this.AssociatedObject.View.GroupDescriptions.Count == 0 ? this.AssociatedObject.View.Records[recordindex] : this.AssociatedObject.View.TopLevelGroup.DisplayElements[recordindex];

            //Returns if caption summary or group summary row encountered.
            if (!recordentry.IsRecords)
                return;

            object value = null;

            if (!this.AssociatedObject.IsInDetailsViewIndex(rowColumnIndex.RowIndex))
            {               
                var record = (recordentry as RecordEntry).Data;
                value = record.GetType().GetProperty(AssociatedObject.Columns[colindex].MappingName).GetValue(record) ?? string.Empty;
                MessageBox.Show("Cell Value : " + value.ToString());
            }
        }

        void AssociatedObject_DetailsViewLoading(object sender, Syncfusion.UI.Xaml.Grid.DetailsViewLoadingAndUnloadingEventArgs e)
        {
            e.DetailsViewDataGrid.MouseDoubleClick += detailsViewDataGrid_MouseDoubleClick;
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.MouseDoubleClick -= AssociatedObject_MouseDoubleClick;
            this.AssociatedObject.DetailsViewLoading -= AssociatedObject_DetailsViewLoading;
            this.AssociatedObject.DetailsViewUnloading -= AssociatedObject_DetailsViewUnloading;
        }
    }
}
