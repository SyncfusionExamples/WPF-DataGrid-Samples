using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SfdataGrid.SortColumnsChanging += SfdataGrid_SortColumnsChanging;
        }

        private async void SfdataGrid_SortColumnsChanging(object sender, Syncfusion.UI.Xaml.Grid.GridSortColumnsChangingEventArgs e)
        {
            e.Cancel = true;
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                await this.SfdataGrid.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   this.SfdataGrid.SortColumnDescriptions.Add(e.AddedItems[0]);
               });
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                await this.SfdataGrid.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
               {
                   var sordesc = this.SfdataGrid.SortColumnDescriptions.FirstOrDefault(sd => sd.ColumnName == e.AddedItems[0].ColumnName);
                   this.SfdataGrid.SortColumnDescriptions.Remove(sordesc);
                   this.SfdataGrid.SortColumnDescriptions.Add(e.AddedItems[0]);
               });
            }
        }
    }
}
