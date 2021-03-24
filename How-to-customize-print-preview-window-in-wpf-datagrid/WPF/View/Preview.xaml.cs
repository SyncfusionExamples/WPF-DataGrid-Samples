using Microsoft.Win32;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.XlsIO;
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
using System.Windows.Shapes;

namespace SfDataGridDemo.View
{
    /// <summary>
    /// Interaction logic for Preview.xaml
    /// </summary>
    public partial class Preview : Window
    {
        const double cmConst = 37.79527559055;
        private PrintManagerBase printManager;
        private PrintPreviewAreaControl printDataContext;
        public SfDataGrid Grid;
        public Preview()
        {
            InitializeComponent();
        }

        void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            printDataContext = e.NewValue as PrintPreviewAreaControl;
            printManager = printDataContext.PrintManagerBase;
        }

        private void OnPartComboPapersSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if(printDataContext == null) return;
            printManager = printDataContext.PrintManagerBase;

            double width = 0;
            double height = 0;
            switch ((e.AddedItems[0] as ComboBoxItem).Content.ToString())
            {
                case "Letter":
                    width = 29.59;
                    height = 27.94;
                    break;

                case "Legal":
                    width = 29.59;
                    height = 35.56;
                    break;

                case "Executive":
                    width = 18.41;
                    height = 26.67;
                    break;

                case "A4":
                    width = 21;
                    height = 29.7;
                    break;

                case "Envelope #10":
                    width = 10.48;
                    height = 24.13;
                    break;

                case "Envelope DL":
                    width = 11;
                    height = 22;
                    break;

                case "Envelope C5":
                    width = 16.2;
                    height = 22.9;
                    break;

                case "Envelope B5":
                    width = 17.6;
                    height = 25;
                    break;

                case "Envelope Monarch":
                    width = 9.84;
                    height = 19.05;
                    break;

                case "Custom Size":
                    OnPageSizeOkButtonClick(null, null);
                    if (PageHeightUpDown != null && PageHeightUpDown.Value != null) height = (double)PageHeightUpDown.Value;
                    if (PageWidthUpDown != null && PageWidthUpDown.Value != null) width = (double)PageWidthUpDown.Value;
                    break;

            }
            if (PageHeightUpDown != null && PageHeightUpDown.Value != null) PageHeightUpDown.Value = height;
            if (PageWidthUpDown != null && PageWidthUpDown.Value != null) PageWidthUpDown.Value = width;
            height *= cmConst;
            width *= cmConst;

            printManager.PrintPageWidth = width;
            printManager.PrintPageHeight = height;
        }

        void OnPageSizeOkButtonClick(object sender, RoutedEventArgs e)
        {

            if (PageHeightUpDown.Value != null)
            {
                var height = (double)PageHeightUpDown.Value * cmConst;
                if (PageWidthUpDown.Value != null)
                {
                    var width = (double)PageWidthUpDown.Value * cmConst;
                    if (height < (printDataContext.PrintPageMargin.Top + printDataContext.PrintPageMargin.Bottom) || width < (printDataContext.PrintPageMargin.Left + printDataContext.PrintPageMargin.Right))
                        return;

                    printDataContext.PrintPageHeight = height;
                    printDataContext.PrintPageWidth = width;
                }
            }
        }

        void OnMarginCmbBoxSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (printDataContext == null) return;
            double left = 0;
            double right = 0;
            double top = 0;
            double bottom = 0;
            switch ((e.AddedItems[0] as ComboBoxItem).Content.ToString())
            {
                case "Normal":
                    left = 2.54;
                    right = 2.54;
                    top = 2.54;
                    bottom = 2.54;
                    break;

                case "Narrow":
                    left = 1.27;
                    right = 1.27;
                    top = 1.27;
                    bottom = 1.27;
                    break;

                case "Moderate":
                    left = 1.91;
                    right = 1.91;
                    top = 2.54;
                    bottom = 2.54;
                    break;

                case "Wide":
                    left = 5.08;
                    right = 5.08;
                    top = 2.54;
                    bottom = 2.54;
                    break;

                case "Custom Margin":
                    OnMarginOkButtonClick(null, null);
                    if (LeftUpDown != null && LeftUpDown.Value != null) left = (double)LeftUpDown.Value;
                    if (RightUpDown != null && RightUpDown.Value != null) right = (double)RightUpDown.Value;
                    if (TopUpDown != null && TopUpDown.Value != null) top = (double)TopUpDown.Value;
                    if (BottomUpDown != null && BottomUpDown.Value != null) bottom = (double)BottomUpDown.Value;

                    break;

            }
            if (LeftUpDown != null && LeftUpDown.Value != null) LeftUpDown.Value = left;
            if (RightUpDown != null && RightUpDown.Value != null) RightUpDown.Value = right;
            if (TopUpDown != null && TopUpDown.Value != null) TopUpDown.Value = top;
            if (BottomUpDown != null && BottomUpDown.Value != null) BottomUpDown.Value = bottom;

            var margin = new Thickness(left * cmConst, top * cmConst, right * cmConst, bottom * cmConst);
            printDataContext.PrintPageMargin = margin;
        }

        void OnMarginOkButtonClick(object sender, RoutedEventArgs e)
        {
            if (LeftUpDown.Value != null)
            {
                var left = (double)LeftUpDown.Value * cmConst;
                if (RightUpDown.Value != null)
                {
                    var right = (double)RightUpDown.Value * cmConst;
                    if (TopUpDown.Value != null)
                    {
                        var top = (double)TopUpDown.Value * cmConst;
                        if (BottomUpDown.Value != null)
                        {
                            var bottom = (double)BottomUpDown.Value * cmConst;

                            var margin = new Thickness(left, top, right, bottom);
                            printDataContext.PrintPageMargin = margin;
                        }
                    }
                }
            }
        }

        private void OnPlusZoomBtnClick(object sender, RoutedEventArgs e)
        {
            if (PartZoomSlider.Value + 10 > PartZoomSlider.MaxHeight) return;
            PartZoomSlider.Value += 10;
        }

        private void OnMinusZoomBtnClick(object sender, RoutedEventArgs e)
        {
            if (PartZoomSlider.Value - 10 < PartZoomSlider.Minimum) return;
            PartZoomSlider.Value -= 10;
        }

        void OnExporttoExcelButtonClick(object sender, RoutedEventArgs e)
        {
            var dataGrid = Grid;
            if (dataGrid == null) return;
            try
            {
                //Setting the Exporting Options by craeting a instance for ExcelExportingOptions.
                var exportingOptions =new  ExcelExportingOptions();
                exportingOptions.ExportAllPages = true;
                exportingOptions.ExportStackedHeaders = true;
                //Below code exports datagrid to excel and returns Excel Engine.
                var excelEngine = dataGrid.ExportToExcel(dataGrid.View, exportingOptions);

                var workBook = excelEngine.Excel.Workbooks[0];

                //saving the workbook using savefiledialog.
                SaveFileDialog sfd = new SaveFileDialog
                {
                    FilterIndex = 2,
                    Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx"
                };

                if (sfd.ShowDialog() == true)
                {
                    using (Stream stream = sfd.OpenFile())
                    {
                        if (sfd.FilterIndex == 1)
                            workBook.Version = ExcelVersion.Excel97to2003;
                        else
                            workBook.Version = ExcelVersion.Excel2010;
                        workBook.SaveAs(stream);
                    }

                    //Message box confirmation to view the created spreadsheet.
                    if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                                        MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        void OnExportPDFButtonClick(object sender, RoutedEventArgs e)
        {
            var dataGrid = Grid;
            if (dataGrid == null) return;
            try
            {
                var options = new PdfExportingOptions();
                options.FitAllColumnsInOnePage = true;
                var document = dataGrid.ExportToPdf(options);

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF Files(*.pdf)|*.pdf"
                };

                if (sfd.ShowDialog() == true)
                {
                    using (Stream stream = sfd.OpenFile())
                    {
                        document.Save(stream);
                    }

                    //Message box confirmation to view the created Pdf file.
                    if (MessageBox.Show("Do you want to view the Pdf file?", "Pdf file has been created",
                                        MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        //Launching the Pdf file using the default Application.
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
