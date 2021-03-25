using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
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
using Syncfusion.UI.Xaml.Grid.Cells;
using System.Collections.Specialized;

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
            sfdatagrid.SelectionController = new GridSelectionControllerExt(this.sfdatagrid);
        }

    }
    public class GridSelectionControllerExt : GridSelectionController
    {        
        public GridSelectionControllerExt(SfDataGrid grid)
            : base(grid)
        {
           
        }

        protected override void ProcessOnGroupChanged(GridGroupingEventArgs args)
        {
            if (this.DataGrid.SelectionMode == GridSelectionMode.None)
                return;
            this.DataGrid.ClearSelections(false);
        }
    }

}
