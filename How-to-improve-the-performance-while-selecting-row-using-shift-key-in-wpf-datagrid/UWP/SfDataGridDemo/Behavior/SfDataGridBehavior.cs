using Microsoft.Xaml.Interactivity;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SfDataGridDemo
{ 
    public class SfDataGridBehavior : Behavior<SfDataGrid>
    {
        SfDataGrid datagrid = null;
        
        protected override void OnAttached()
        {
            datagrid = this.AssociatedObject as SfDataGrid;
            datagrid.SelectionController = new GridSelectionControllerExt(datagrid);
            base.OnAttached();
        }
    }
}
