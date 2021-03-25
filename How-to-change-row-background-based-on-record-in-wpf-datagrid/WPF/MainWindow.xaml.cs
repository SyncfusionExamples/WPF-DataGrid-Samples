using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.Grid.Cells;

namespace ManualRefresh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.datagrid.ItemsSourceChanged += datagrid_ItemsSourceChanged;          
        }

        void datagrid_ItemsSourceChanged(object sender, GridItemsSourceChangedEventArgs e)
        {
            if (this.datagrid.View != null)
                this.datagrid.View.RecordPropertyChanged += View_RecordPropertyChanged;
        }

        void View_RecordPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsChecked")
            {
                var datarow = this.datagrid.GetRowGenerator().Items.FirstOrDefault(row => row.RowIndex != -1 && row.RowData == sender);
                if (datarow != null)
                {
                    var rowcontrol = (datarow as IRowElement).Element;
                    BindingOperations.GetBindingExpression(rowcontrol, VirtualizingCellsControl.BackgroundProperty).UpdateTarget();
                }
            }
        }
    }
}