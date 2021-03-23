# How to scroll multiple items for one mouse wheel in WPF DataGrid (SfDataGrid)?

This sample show cases how to scroll the multiple items for one mouse wheel in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid).

You can scroll only one item while doing MouseWheel in [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid). But you can scroll multiple items while doing MouseWheel by handling the `DataGrid.PreviewMouseWheel` event and calling the `MouseWheelUp` and `MouseWheelDown` based on the delta value.