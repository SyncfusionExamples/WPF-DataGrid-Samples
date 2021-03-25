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
using Syncfusion.UI.Xaml.Utility;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.Windows.Shared;
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
            this.datagrid.SelectionController = new RowSelectionController(this.datagrid);
        }      
    }
     
}
