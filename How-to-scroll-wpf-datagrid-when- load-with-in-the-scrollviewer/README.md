# How to scroll WPF DataGrid (SfDataGrid) when we load with in the ScrollViewer?

This sample show cases how to scroll [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) when we load with the ScrollViewer.

You can load the [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) into the ScrollViewer. But you can’t be able to scroll the [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfSDataGrid) through mouse wheel, where you can overcome this by using `ScrollViewer.ScrollToVerticalOffset` method in `SfDataGrid.PreviewMouseWheel` event.