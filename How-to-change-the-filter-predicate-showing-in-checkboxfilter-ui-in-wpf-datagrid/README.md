# How to change the filter predicate showing in CheckBoxFilter UI in WPF DataGrid (SfDataGrid)?

This sample show cases how to change the filter predicate showing in CheckBoxFilter UI in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The items will be loaded inside the [CheckBoxFilterControl](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.CheckboxFilterControl.html) based on the display text of FilterElement by default in GridFilterControl. You can also change the display text of [CheckBoxFilterControl](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.CheckboxFilterControl.html) in `FilterItemsPopulated` event.

Due to performance reasons [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) creates filter predicates based on checked and unchecked items count (which count is less). However, you can change the filter predicate based on your display text in `FilterChanging` event.
