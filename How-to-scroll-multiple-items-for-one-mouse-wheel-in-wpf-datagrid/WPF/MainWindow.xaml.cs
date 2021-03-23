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
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Utility;

namespace SfDataGridDemo
{   
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            //You can scroll multiple items while doing MouseWheel using PreviewMouseWheel event.         
            this.dataGrid.PreviewMouseWheel += DataGrid_PreviewMouseWheel;         
        }      
        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta == 0)
                return;

            if (e.Delta > 0)
            {
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelUp();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelUp();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelUp();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelUp();
            }
            else
            {
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelDown();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelDown();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelDown();
                (this.dataGrid.GetVisualContainer() as IScrollableInfo).MouseWheelDown();
            }
        }
    }       
}   

