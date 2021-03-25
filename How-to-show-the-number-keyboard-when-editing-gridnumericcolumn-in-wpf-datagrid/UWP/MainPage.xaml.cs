using Syncfusion.Data;
using Syncfusion.UI.Xaml.Controls.Input;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            //Remove existing NumericTextBox Renderer
            this.sfdatagrid.CellRenderers.Remove("Numeric");
            // Add customized NumericTextBox Renderer.
            this.sfdatagrid.CellRenderers.Add("Numeric", new CustomizedGridCellNumericRenderer());
        }
        public class CustomizedGridCellNumericRenderer : GridCellNumericRenderer
        {
            protected override SfNumericTextBox OnCreateEditUIElement()
            {
                var element= base.OnCreateEditUIElement();
                InputScope scope = new InputScope();
                InputScopeName name = new InputScopeName();
                name.NameValue = InputScopeNameValue.Number;
                scope.Names.Add(name);
                element.InputScope = scope;
                return element;
            }
        }

    
    }
}
