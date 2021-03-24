using Syncfusion.Data;
using Syncfusion.UI.Xaml.Controls.Input;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
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
            sfdatagrid.CurrentCellEndEdit += sfdatagrid_CurrentCellEndEdit;
        }

        private void sfdatagrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs args)
        {
            var selectedcells = sfdatagrid.GetSelectedCells();
            var propertyAccessProvider = this.sfdatagrid.View.GetPropertyAccessProvider();
            var itemProperties = sfdatagrid.View.GetItemProperties();
            var newValue = propertyAccessProvider.GetValue(sfdatagrid.CurrentItem,sfdatagrid.CurrentColumn.MappingName);
            if (selectedcells.Count > 0)
            {
                try
                {
                    selectedcells.ForEach(item =>
                    {
                        var cellInfo = item as GridCellInfo;
                        var propInfo = itemProperties.Find(cellInfo.Column.MappingName, true);
                        if (propInfo != null && propInfo.PropertyType == newValue.GetType())
                            propertyAccessProvider.SetValue(cellInfo.RowData, cellInfo.Column.MappingName, newValue);
                        else if (propInfo != null)
                        {
                            var value = Convert.ChangeType(newValue, propInfo.PropertyType);
                            propertyAccessProvider.SetValue(cellInfo.RowData, cellInfo.Column.MappingName, value);
                        }
                    });
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }
    }
}
