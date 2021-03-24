using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IPropertyAccessProvider reflector = null;
        public MainPage()
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
