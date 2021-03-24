using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Controls.Input;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.dataGrid.Loaded += DataGrid_Loaded;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var selectedItem = (this.DataContext as ViewModel).SelectedItem;
            var rowindex = this.dataGrid.ResolveToRowIndex(selectedItem);
            var columnindex = this.dataGrid.ResolveToStartColumnIndex();
            //Make the row in to available on the view. 
            this.dataGrid.ScrollInView(new RowColumnIndex(rowindex, columnindex));
            //to set the found row as current row 
            this.dataGrid.View.MoveCurrentTo(selectedItem);

        }
    }
}