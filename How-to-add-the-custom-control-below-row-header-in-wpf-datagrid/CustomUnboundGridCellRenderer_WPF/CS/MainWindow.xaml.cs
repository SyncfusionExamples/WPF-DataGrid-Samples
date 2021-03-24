using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
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
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace UnBoundRowDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();       
            sfDataGrid.QueryUnBoundRow += sfDataGrid_QueryUnBoundRow;          
            sfDataGrid.UnBoundRowCellRenderers.Add("GridUnBoundRowCellTextBoxRendererExt", new GridUnBoundRowCellTextBoxRendererExt());
        }


     
        void sfDataGrid_QueryUnBoundRow(object sender, Syncfusion.UI.Xaml.Grid.GridUnBoundRowEventsArgs e)
        {
           
            if (e.UnBoundAction == UnBoundActions.QueryData)
            {
                if (e.GridUnboundRow.UnBoundRowIndex == 0 && e.GridUnboundRow.Position == UnBoundRowsPosition.Top)
                {
                    if (e.Column.MappingName=="QS2")
                    {
                        e.CellType = "GridUnBoundRowCellTextBoxRendererExt";
                        e.Value = (sfDataGrid.DataContext as SalesInfoViewModel).DisplayValue;
                        e.Handled = true;                      
                    }
                }
            }
            else if(e.UnBoundAction == UnBoundActions.CommitData)
            {
                if (e.Column.MappingName == "QS2" && e.Value != null)
                {
                    var binding = new Binding();
                    binding.Converter = new CurrencyConverter();
                    binding.ConverterParameter = e.Value.ToString();
                    sfDataGrid.Columns[2].DisplayBinding = binding;
                    sfDataGrid.Columns[2].ValueBinding = binding;                
                }
            }
            e.Handled = true;
        }

    }
}
