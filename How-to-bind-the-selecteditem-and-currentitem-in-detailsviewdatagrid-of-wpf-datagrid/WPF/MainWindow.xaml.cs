using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace DetailsView_NestedLevel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.datagrid.SelectionChanged += datagrid_SelectionChanged;
            this.DetailsViewGrid.SelectionChanged += DetailsViewGrid_SelectionChanged;
        }

        private void datagrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            var data = this.datagrid.SelectionController.SelectedRows;
        }

        void DetailsViewGrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            var grid = (e.OriginalSender as DetailsViewDataGrid);
            var selectedrows = grid.SelectionController.SelectedRows;
            var selecteditems = grid.SelectedItems;
        }               
    }
}
