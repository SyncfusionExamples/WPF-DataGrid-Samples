using Syncfusion.Windows.Tools.Controls;
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
using System.Globalization;
using Syncfusion.UI.Xaml.Grid;

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
            this.datagrid.CurrentCellValidating += Datagrid_CurrentCellValidating;
        }

        private void Datagrid_CurrentCellValidating(object sender, CurrentCellValidatingEventArgs args)
        {
            if (args.Column.MappingName != "salary")
                return;

            double d;
            if(args.NewValue == null || !double.TryParse(args.NewValue.ToString(), out d))
            {
                args.ErrorMessage = "Enter valid double value";
                args.IsValid = false;
            }
        }
    }
}
