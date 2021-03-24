using Syncfusion.Data;
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
            sfDataGrid.QueryUnBoundRow += sfDataGrid_QueryUnBoundRow;
            sfDataGrid.UnBoundRowCellRenderers.Add("GridUnBoundRowCellTextBoxRendererExt", new GridUnBoundRowCellTextBoxRendererExt());
        }



        void sfDataGrid_QueryUnBoundRow(object sender, Syncfusion.UI.Xaml.Grid.GridUnBoundRowEventsArgs e)
        {

            if (e.UnBoundAction == UnBoundActions.QueryData)
            {
                if (e.GridUnboundRow.UnBoundRowIndex == 0 && e.GridUnboundRow.Position == UnBoundRowsPosition.Top)
                {
                    if (e.Column.MappingName == "Salary")
                    {
                        e.CellType = "GridUnBoundRowCellTextBoxRendererExt";
                        e.Value = (sfDataGrid.DataContext as ViewModel).DisplayValue;
                        e.Handled = true;
                    }
                }
            }
            else if (e.UnBoundAction == UnBoundActions.CommitData)
            {
                if (e.Column.MappingName == "Salary" && e.Value != null)
                {
                    var binding = new Binding();
                    binding.Converter = new CurrencyConverter();
                    binding.ConverterParameter = e.Value.ToString();
                    sfDataGrid.Columns[4].DisplayBinding = binding;
                    sfDataGrid.Columns[4].ValueBinding = binding;
                }
            }
            e.Handled = true;
        }


       
    }
    
}
