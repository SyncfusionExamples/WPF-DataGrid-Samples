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
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.Windows.PdfViewer;
using System.IO;
using Syncfusion.Pdf.Parsing;
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
            this.sfdatagrid.Loaded += sfdatagrid_Loaded;
        }

        void sfdatagrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.sfdatagrid.ExpandAllDetailsView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PdfExportingOptions options = new PdfExportingOptions();
            options.ExportDetailsView = true;
            var document = sfdatagrid.ExportToPdf(options);
            MemoryStream stream = new MemoryStream();
            document.Save(stream);
            PdfLoadedDocument ldoc = new PdfLoadedDocument(stream);
            PdfViewerControl pdfViewer = new PdfViewerControl();
            
            Window window = new Window();
            Grid grid = new Grid();
            window.Content = grid;

            //Load the PdfDocument in to PdfViewer
            pdfViewer.Load(ldoc);
            grid.Children.Add(pdfViewer);
            window.Show();
        }
    }
}
