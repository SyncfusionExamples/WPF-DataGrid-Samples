using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
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
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;

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
            this.datagrid.CurrentCellValueChanged += datagrid_CurrentCellValueChanged;
        }

        public void datagrid_CurrentCellValueChanged(object sender, CurrentCellValueChangedEventArgs args)
        {          
            int columnindex = datagrid.ResolveToGridVisibleColumnIndex(args.RowColumnIndex.ColumnIndex);
            var column = datagrid.Columns[columnindex];
            if (column is GridCheckBoxColumn)
            {
                var rowIndex = this.datagrid.ResolveToRecordIndex(args.RowColumnIndex.RowIndex);
                RecordEntry record=null;
                if(this.datagrid.GroupColumnDescriptions.Count==0)
                {
                    record = this.datagrid.View.Records[rowIndex] as RecordEntry;                    
                }
                else
                {
                    record = (this.datagrid.View.TopLevelGroup.DisplayElements[rowIndex] as RecordEntry);
                }
                //Checkbox property changed value is stored here.
                var value = (record.Data as Model).Review;
            }
        }
    }
}
         
   

