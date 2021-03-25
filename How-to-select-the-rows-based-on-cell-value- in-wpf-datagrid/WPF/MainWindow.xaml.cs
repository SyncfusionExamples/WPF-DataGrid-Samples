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
        IPropertyAccessProvider reflector = null;
        public MainWindow()
        {
            InitializeComponent();          
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.View != null)
                reflector = datagrid.View.GetPropertyAccessProvider();
            else
                reflector = null;

            var totalRowIndex = datagrid.View.Records.Count;
            var totalColumnIndex = datagrid.Columns.Count;
            for (int recordIndex = 0; recordIndex < totalRowIndex; recordIndex++)
            {
                for (int colindex = 0; colindex < totalColumnIndex; colindex++)
                {
                    var record = this.datagrid.View.Records[recordIndex];
                    var mappingName = datagrid.Columns[colindex].MappingName;
                    //Get the cell value based on mappingName.
                    var currentCellValue = reflector.GetValue(record.Data, mappingName);
                    if (currentCellValue == "Bulk")
                    {
                        object item = datagrid.View.Records[recordIndex];
                        //selected rows should be added here.
                        datagrid.SelectedItems.Add(item);
                    }
                }
            }
        }
    }
}
                       
        
    