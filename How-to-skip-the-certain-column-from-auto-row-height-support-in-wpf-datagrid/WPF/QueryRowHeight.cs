using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace RowHeight
{
    public class ExlucedColumnsList : List<string>
    {

    }

    public class QueryRowHeightBehaviour : Behavior<SfDataGrid>
    {
        public ExlucedColumnsList ExlucedColumnsList
        {
            get { return (ExlucedColumnsList)GetValue(ExlucedColumnsListProperty); }
            set { SetValue(ExlucedColumnsListProperty, value); }
        }

        public static readonly DependencyProperty ExlucedColumnsListProperty =
            DependencyProperty.Register("ExlucedColumnsList", typeof(ExlucedColumnsList), typeof(QueryRowHeightBehaviour), new PropertyMetadata(null));

        GridRowSizingOptions gridRowResizingOptions = new GridRowSizingOptions();
        double Height = double.NaN;

        protected override void OnAttached()
        {
            this.AssociatedObject.QueryRowHeight += AssociatedObject_QueryRowHeight;
            gridRowResizingOptions.ExcludeColumns = ExlucedColumnsList;
        }

        void AssociatedObject_QueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            if (this.AssociatedObject.IsTableSummaryIndex(e.RowIndex))
            {
                e.Height = 40;
                e.Handled = true;
            }
            else if (this.AssociatedObject.GridColumnSizer.GetAutoRowHeight(e.RowIndex, gridRowResizingOptions, out Height))
            {
                if (Height > this.AssociatedObject.RowHeight)
                {
                    e.Height = Height;
                    e.Handled = true;
                }
            }
        }
    }
}
