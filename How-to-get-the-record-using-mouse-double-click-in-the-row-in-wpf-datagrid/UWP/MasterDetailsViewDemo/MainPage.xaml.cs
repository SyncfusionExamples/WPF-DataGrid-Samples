using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MasterDetailsViewDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //  this.dataGrid.SelectionChanged += DataGrid_SelectionChanged;
        }

        //    private void DataGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        //    {
        //        if (e.RemovedItems.Count > 0)
        //        {
        //            var rowIndex = (e.RemovedItems[0] as GridRowInfo).RowIndex;
        //            var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(this.dataGrid.ResolveToRecordIndex(rowIndex), "OrderDetails");
        //            if (detailsViewDataGrid == null)
        //                return;
        //            detailsViewDataGrid.Background = new SolidColorBrush(Windows.UI.Colors.LightBlue);
        //        }
        //        if (e.AddedItems.Count > 0)
        //        {
        //            var rowIndex = (e.AddedItems[0] as GridRowInfo).RowIndex;
        //            var detailsViewDataGrid = this.dataGrid.GetDetailsViewGrid(this.dataGrid.ResolveToRecordIndex(rowIndex), "OrderDetails");
        //            if (detailsViewDataGrid == null)
        //                return;
        //            detailsViewDataGrid.Background = new SolidColorBrush(Windows.UI.Colors.LightGreen);
        //        }
        //    }


        //}    
        //public class BGConverter : IValueConverter
        //{
        //    public object Convert(object value, Type targetType, object parameter, string language)
        //    {
        //        return "DarkGray";
        //    }
        //    public object ConvertBack(object value, Type targetType, object parameter, string language)
        //    {
        //        return null;
        //    }
        //}
    }
}
