using Syncfusion.Data;
using Syncfusion.UI.Xaml.Controls.Input;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
            sfdatagrid.SelectionController = new GridSelectionControllerExt(sfdatagrid);
        }

        public class GridSelectionControllerExt : GridSelectionController
        {
            public GridSelectionControllerExt(SfDataGrid sfdatagrid) : base(sfdatagrid)
            {
            }
            public override bool HandleKeyDown(KeyRoutedEventArgs args)
            {             
                if (args.Key == Windows.System.VirtualKey.Escape)
                {
                    if (this.DataGrid.View.IsAddingNew)
                    {
                        if (this.CurrentCellManager.CurrentCell.IsEditing)
                            this.CurrentCellManager.EndEdit(true);
                        this.DataGrid.GetAddNewRowController().CancelAddNew();
                    }
                }
                return base.HandleKeyDown(args);
            }
        }    
    }
}
