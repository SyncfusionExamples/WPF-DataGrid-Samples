using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

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
