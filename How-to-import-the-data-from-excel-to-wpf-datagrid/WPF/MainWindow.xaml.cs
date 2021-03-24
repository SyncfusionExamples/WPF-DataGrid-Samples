using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections;
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
using SfDataGrid_ComboBoxDemo;
using System.Collections.ObjectModel;
using System.Data;
using Syncfusion.XlsIO;

namespace SfDataGrid_ComboBoxDemo
{   
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;                              
        }       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2013;

            IWorkbook workbook = application.Workbooks.Create(1);

            IWorksheet worksheet = workbook.Worksheets[0];

            //Import the data to worksheet.
            IList<OrderInfo> reports = viewModel.Generate();
            worksheet.ImportData(reports, 1, 1, true);

            // Read data from the worksheet and Export to the DataTable.
           
            DataTable customersTable = worksheet.ExportDataTable(1, 1, 15, 5, ExcelExportDataTableOptions.ColumnNames);

            this.dataGrid.ItemsSource = customersTable;

            workbook.Close();

            excelEngine.Dispose();
        }      
    }
}

