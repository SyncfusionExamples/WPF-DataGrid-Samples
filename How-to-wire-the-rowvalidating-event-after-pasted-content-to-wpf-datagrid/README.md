# How to wire the RowValidating event after pasted content to WPF DataGrid (SfDataGrid)?

This sample show cases how to wire the RowValidating event after pasted content to [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The row validation event is raised on the validation state of the row editing in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) and is not on the content pasted in the row. You can fire the row validating event after pasting the content by marking the current row validated flag as false using the [ValidationHelper.SetCurrentRowValidated](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.ValidationHelper.html#Syncfusion_UI_Xaml_Grid_ValidationHelper_SetCurrentRowValidated_System_Boolean_) method in [PasteGridCellContent](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_PasteGridCellContent) event.

KB article - [How to wire the RowValidating event after pasted content to WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/9432/how-to-wire-the-rowvalidating-event-after-pasted-content-to-wpf-datagrid-sfdatagrid)
