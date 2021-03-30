# How to display the group header based on the column name in WPF DataGrid (SfDataGrid)?

This sample show cases how to display the group header based on the column in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The group header name is displayed only based on the grouped column header name. In order to display group Header name based on the other column, you need to customize the `GridCaptionSummaryCellRenderer` and override the `OnInitializeEditElement` and `OnUpdateEditBinding` methods in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).