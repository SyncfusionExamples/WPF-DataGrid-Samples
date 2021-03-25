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

namespace CheckBoxSelectAllRowSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.datagrid.SelectionController = new RowSelectionController(this.datagrid);
        }
        
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkbox = (sender as CheckBox).IsChecked;
            if (checkbox == false)
            {
                var viewmodel = (this.datagrid.DataContext as ViewModel);
                this.datagrid.ClearSelections(false);
                foreach (var collection in viewmodel.OrderInfoCollection)
                {
                    if (collection.IsSelected == true)
                        collection.IsSelected = false;
                }
            }
            else if (checkbox == true)
            {
                var viewmodel = (this.datagrid.DataContext as ViewModel);
                this.datagrid.SelectAll();
                foreach (var collection in viewmodel.OrderInfoCollection)
                {
                    if (collection.IsSelected == false)
                        collection.IsSelected = true;
                }
            }

        }

    }
}
