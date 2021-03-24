using System.Windows;
using Syncfusion.UI.Xaml.ScrollAxis;
using System.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.Loaded += DataGrid_Loaded;
        }
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var selectedItem = (this.DataContext as Viewmodel).SelectedItem;
            var rowindex = this.dataGrid.ResolveToRowIndex(selectedItem);
            var columnindex = this.dataGrid.ResolveToStartColumnIndex();
            //Make the row in to available on the view. 
            this.dataGrid.ScrollInView(new RowColumnIndex(rowindex, columnindex));
            //to set the found row as current row 
            this.dataGrid.View.MoveCurrentTo(selectedItem);
        }
    }
}
