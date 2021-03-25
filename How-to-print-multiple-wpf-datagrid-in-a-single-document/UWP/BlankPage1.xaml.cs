using Syncfusion.UI.Xaml.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Grid;
using System.Collections.ObjectModel;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }               
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, new Windows.UI.Core.DispatchedHandler(() =>
            {
                var grids = e.Parameter;

                var gridArray = grids as object[];
                var grid1 = gridArray[0] as SfDataGrid;
                var grid2 = gridArray[1] as SfDataGrid;              

                Assembly assembly = typeof(BlankPage1).GetTypeInfo().Assembly;
                Stream reportStream = assembly.GetManifestResourceStream("SfDataGridDemo.Report1.rdlc");

                this.ReportViewer.ProcessingMode = ProcessingMode.Local;
                this.ReportViewer.ExportMode = ExportMode.Local;
                this.ReportViewer.LoadReport(reportStream);
              
                this.ReportViewer.DataSources.Clear();

                //Add Datasource and set ItemsSource for grid1.
                this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "DataSet1", Value = grid1.ItemsSource as ObservableCollection<Model> });

                //Add Datasource and set ItemsSource for grid1.
                this.ReportViewer.DataSources.Add(new ReportDataSource { Name = "DataSet2", Value = grid2.ItemsSource as ObservableCollection<Model> });
                this.ReportViewer.RefreshReport();
            }));
        }
    }
}
