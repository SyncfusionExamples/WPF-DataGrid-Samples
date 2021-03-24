# How to clear the selection while grouping or ungrouping in WPF DataGrid (SfDataGrid)?

This sample show cases how to clear the selection while grouping or ungrouping in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

The first caption summary row is selected by default when you are grouping the column in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid). You can clear the default selection in first row while grouping or ungrouping by overriding [GridSelectionController](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridSelectionController.html) or [GridCellSelectionController](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridCellSelectionController.html) based on the [SelectionUnit](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_SelectionUnit).

You can call [SfDataGrid.ClearSelections](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_ClearSelections_System_Boolean_) (bool exceptCurrentRow) method inside `ProcessOnGroupChanged` override of selection controller to clear the selection while grouping and ungrouping.

