# How to show the number keyboard when editing GridNumericColumn in WPF DataGrid (SfDataGrid)?

This sample show cases how to show the number keyboard when editing the GridNumericColumn in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

You can show the number keyboard for numeric columns by setting Input Scope property for SfNumericTextBox in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). `InputScope` property provides a type of text input expected by that control.

You can achieve this by deriving a new class from `GridCellNumericRenderer` and override the `OnCreateEditUIElement` method. By setting `InputScopeNameValue` as Number for SfNumericTextBox in `OnCreateEditUIElement` method, which shows NumericKeyboard when touch keyboard in Numeric Columns.

