using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
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
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;
using System.Collections.ObjectModel;

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
            this.SfdataGrid.PreviewMouseWheel += SfdataGrid_PreviewMouseWheel;
            this.SfdataGrid2.PreviewMouseWheel += SfdataGrid2_PreviewMouseWheel;
        }

        void SfdataGrid2_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollviewer.ScrollToVerticalOffset(scrollviewer.VerticalOffset - e.Delta / 3);
        }

        void SfdataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            scrollviewer.ScrollToVerticalOffset(scrollviewer.VerticalOffset - e.Delta / 3);
        }     
    }
}
         
   

