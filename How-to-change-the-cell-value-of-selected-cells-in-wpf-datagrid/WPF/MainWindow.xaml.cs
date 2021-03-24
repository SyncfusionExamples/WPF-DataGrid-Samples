using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
using Syncfusion.UI.Xaml.Utility;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls.Primitives;
using System.Diagnostics;

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
            sfdatagrid.CurrentCellEndEdit+=sfdatagrid_CurrentCellEndEdit;
        }

        void sfdatagrid_CurrentCellEndEdit(object sender, CurrentCellEndEditEventArgs args)
        {
            var selectedcells = this.sfdatagrid.GetSelectedCells();
            var propertyAccessProvider = this.sfdatagrid.View.GetPropertyAccessProvider();
            var itemProperties = this.sfdatagrid.View.GetItemProperties();
            var newValue = propertyAccessProvider.GetValue(this.sfdatagrid.CurrentItem, this.sfdatagrid.CurrentColumn.MappingName);
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

