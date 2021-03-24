using Syncfusion.Data;
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
        protected SfDataGrid DataGrid;
        ColumnChooser chooserWindow;
        OrderInfoViewModel viewModel;
        public MainPage()
        {
            this.InitializeComponent();
            this.DataGrid = sfGrid;
            this.DataContext = viewModel = new OrderInfoViewModel();
            this.sfGrid.Loaded += OnSfGrid_Loaded;
            this.sfGrid.Unloaded += OnSfGrid_Unloaded;
        }
        void OnSfGrid_Loaded(object sender, RoutedEventArgs e)
        {
            chooserWindow = new ColumnChooser(this.sfGrid);
            chooserWindow.Resources.MergedDictionaries.Clear();
            chooserWindow.ClearValue(ColumnChooser.StyleProperty);
            chooserWindow.Title = "Column Picker";
            chooserWindow.Background = new SolidColorBrush(Colors.Pink);
            chooserWindow.WaterMarkText = "No columns Available";
            chooserWindow.Foreground = new SolidColorBrush(Colors.BlueViolet);
            chooserWindow.TitleBarForeground = new SolidColorBrush(Colors.White);
            chooserWindow.TitleBarBackground = new SolidColorBrush(Colors.BlueViolet);
            chooserWindow.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("ms-appx:///Syncfusion.SfGrid.UWP/Styles/Styles.xaml", UriKind.RelativeOrAbsolute) });
            this.sfGrid.GridColumnDragDropController = new GridColumnChooserController(this.sfGrid, chooserWindow);
            viewModel.toggled = OnToggled;
            ShowColumnChooser();
            chooserWindow.Popup.Closed += OnPopup_Closed;
        }

        void OnSfGrid_Unloaded(object sender, RoutedEventArgs e)
        {
            chooserWindow.Popup.IsOpen = false;
        }
        void ShowColumnChooser()
        {
            this.DataGrid.Columns.ForEach(col =>
            {
                //You can Remove column When the isHidden property as true
                if (col.IsHidden)
                    chooserWindow.RemoveChild(col);
            });
            chooserWindow.Popup.HorizontalOffset = (this.sfGrid.ActualWidth) / 2;
            chooserWindow.Popup.VerticalOffset = (this.sfGrid.ActualHeight) / 2;
            chooserWindow.Popup.IsOpen = true;
        }
        void OnCustomChooser_Closed(object sender, object e)
        {
            viewModel.ShowColumnChooser = false;
        }

        private void OnToggled()
        {
            if (viewModel.ShowColumnChooser)
                ShowColumnChooser();
            else
            {
                chooserWindow.Popup.IsOpen = false;
            }
        }

        private void OnPopup_Closed(object sender, object e)
        {
            viewModel.ShowColumnChooser = false;
        }
    }
}
