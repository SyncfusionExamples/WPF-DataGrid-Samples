# How to load the collection in GridComboBoxColumn of WPF DataGrid (SfDataGrid)?

This sample show cases how to load the collection in GridComboBoxColumn when defining the data context after loading window in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The [GridComboBoxColumn](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridComboBoxColumn.html) will loads the collection when defining DataContext before loading the [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). When you are defining the DataContext in Window.Loaded event, the binding will not be updated for [GridComboBoxColumn](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridComboBoxColumn.html) which loads the empty collection. But you can achieve this by using Freezable class

KB article - [How to load the collection in GridComboBoxColumn of WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/6701/how-to-load-the-collection-in-gridcomboboxcolumn-when-defining-datacontext-after-loading)
