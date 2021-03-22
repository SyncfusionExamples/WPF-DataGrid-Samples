using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;

namespace SfDataGridDemo
{
    public class SfDataGridBehavior : Behavior<SfDataGrid>
    {
        SfDataGrid dataGrid = null;
        ViewModel viewModel = new ViewModel();
        protected override void OnAttached()
        {
            dataGrid = this.AssociatedObject as SfDataGrid;
            //dataGrid.ItemsSource = viewModel.DynamicCollection;
            dataGrid.ItemsSource = new QueryableViewExt(viewModel.DynamicCollection, dataGrid);

            base.OnAttached();
        }
    }
}
