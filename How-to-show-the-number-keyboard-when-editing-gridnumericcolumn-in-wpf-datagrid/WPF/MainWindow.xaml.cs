using Syncfusion.UI.Xaml.Grid;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Grid.Cells;

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
            InitializeComponent();           
            //Remove existing NumericTextBox Renderer
            this.sfdatagrid.CellRenderers.Remove("Numeric");
            // Add customized NumericTextBox Renderer.
            this.sfdatagrid.CellRenderers.Add("Numeric", new CustomizedGridCellNumericRenderer());
        }

    }
    public class CustomizedGridCellNumericRenderer : GridCellNumericRenderer
    {
        protected override Syncfusion.Windows.Shared.DoubleTextBox OnCreateEditUIElement()
        {
            var element = base.OnCreateEditUIElement();
            InputScope scope = new InputScope();
            InputScopeName name = new InputScopeName();
            name.NameValue = InputScopeNameValue.Number;
            scope.Names.Add(name);
            element.InputScope = scope;
            return element;
        
        }
    }

  

}
