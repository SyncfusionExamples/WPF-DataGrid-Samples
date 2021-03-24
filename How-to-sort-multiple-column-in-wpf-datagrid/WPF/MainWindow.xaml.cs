using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

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
            SfdataGrid.SortColumnsChanging += SfdataGrid_SortColumnsChanging;
        }

        void SfdataGrid_SortColumnsChanging(object sender, GridSortColumnsChangingEventArgs e)
        {
            e.Cancel = true;
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                this.SfdataGrid.Dispatcher.BeginInvoke(new Action(() =>
                {
                    this.SfdataGrid.SortColumnDescriptions.Add(e.AddedItems[0]);
                }), DispatcherPriority.ApplicationIdle);

            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                this.SfdataGrid.Dispatcher.BeginInvoke(new Action(() =>
                {
                    var sordesc = this.SfdataGrid.SortColumnDescriptions.FirstOrDefault(sd => sd.ColumnName == e.AddedItems[0].ColumnName);
                    this.SfdataGrid.SortColumnDescriptions.Remove(sordesc);
                    this.SfdataGrid.SortColumnDescriptions.Add(e.AddedItems[0]);
                }), DispatcherPriority.ApplicationIdle);
            }
        }
    }
}
