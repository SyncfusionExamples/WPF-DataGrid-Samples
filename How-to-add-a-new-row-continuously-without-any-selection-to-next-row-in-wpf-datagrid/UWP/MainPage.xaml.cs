using SfDataGridDemo;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Input;
using System.Threading;
using Syncfusion.UI.Xaml.ScrollAxis;
using Windows.System;
using Windows.UI.Core;

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
            InitializeComponent();
        }
        private void datagrid_CurrentCellActivated(object sender, CurrentCellActivatedEventArgs args)
        {    
            //Skip the selection moved to next row when adding new row.        
            bool needToMove = (dataGrid.IsAddNewIndex(args.PreviousRowColumnIndex.RowIndex)
                && !dataGrid.IsAddNewIndex(args.CurrentRowColumnIndex.RowIndex)
                && (Window.Current.CoreWindow.GetAsyncKeyState(VirtualKey.Enter).HasFlag(CoreVirtualKeyStates.Down) || Window.Current.CoreWindow.GetAsyncKeyState(VirtualKey.Tab).HasFlag(CoreVirtualKeyStates.Down)));

            Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () =>
               {
                   var gridModel = this.dataGrid.GetGridModel();
                   var columnIndex = this.dataGrid.GetFirstColumnIndex();
                   if (needToMove && gridModel != null)
                   {
                       this.dataGrid.MoveCurrentCell(new RowColumnIndex(gridModel.AddNewRowController.GetAddNewRowIndex(), columnIndex));
                   }
               });
        }
    }
}
