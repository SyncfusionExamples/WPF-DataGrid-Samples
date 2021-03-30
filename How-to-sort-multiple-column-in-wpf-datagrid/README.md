# How to sort multiple column in WPF DataGrid (SfDataGrid)?

This sample show cases how to sort the multiple column without pressing Ctrl key in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

[WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) allows you to perform the multiple sorting without pressing the Ctrl Key. You can achieve this by using the `SortColumnChanging` event which will be raised while clicking on the column header. You should cancel the current sorting process and need to add the new sort column to SorColumnDescriptions using a Dispatcher.