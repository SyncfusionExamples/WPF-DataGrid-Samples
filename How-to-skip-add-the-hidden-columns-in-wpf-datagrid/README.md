# How to skip add the hidden columns in WPF DataGrid (SfDataGrid)?

This sample show cases how to skip add the hidden columns in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

You can skip the hidden columns in the [ColumnChooser](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.ColumnChooser.html) by writing a custom ColumnChooser class extending from [IColumnChooser](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.IColumnChooser.html) and removing the hidden columns from the Children collection in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). This change can be done by overriding the `OnApplyTemplate` method of the `CustomColumnChooser` class.

KB article - [How to skip add the hidden columns in WPF DataGrid (SfDataGrid)](https://www.syncfusion.com/kb/7839/how-to-skip-add-the-hidden-columns-in-wpf-datagrid-sfdatagrid)
