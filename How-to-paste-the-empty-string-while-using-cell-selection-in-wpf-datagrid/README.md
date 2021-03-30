# How to paste the empty string while using cell selection in WPF DataGrid (SfDataGrid)?

This sample show cases how to paste the empty string while using the cell selection in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The empty string will not be allowed to paste in [GridCell](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridCell.html) when the [SelectionUnit](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_SelectionUnit) is Cell or Any in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). But you can achieve this by overriding the `PasteToRow` method in [GridCutCopyPaste](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridCutCopyPaste.html) class.
