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
using Syncfusion.Windows.Reports.Viewer;


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
        }
        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            ReportViewer reportViewer1 = new ReportViewer();

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.ReportPath = @"../../Report1.rdlc";
            reportViewer1.DataSources.Clear();

            //Add Datasource and set ItemsSource for grid1.
            reportViewer1.DataSources.Add(new Syncfusion.Windows.Reports.ReportDataSource()
            {
                Name = "DataSet1",
                Value = grid1.ItemsSource

            });

            //Add Datasource and set ItemsSource for grid1.
            reportViewer1.DataSources.Add(new Syncfusion.Windows.Reports.ReportDataSource()
            {
                Name = "DataSet2",
                Value = grid2.ItemsSource

            });

            Print rv = new Print();
            rv.Content = reportViewer1;
            reportViewer1.RefreshReport();
            rv.Show();
        }       
    }  
}
         
   

