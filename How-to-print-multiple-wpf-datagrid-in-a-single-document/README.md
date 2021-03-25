# How to print multiple WPF DataGrid (SfDataGrid) in a single document?

This sample show cases how to print the multiple [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) in a single document.

[WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) does not have direct support to print multiple SfDataGrid in single document. But you can achieve this by using Syncfuion ReportViewer control which will print multiple [WPF DataGrid](https://www.syncfusion.com/wpf-ui-controls/datagrid) (SfDataGrid) in a single document. You have to create a RDLC file with DataSet and also you need to set DataSources for ReportViewer from `SfDataGrid.ItemsSource` property.