# How to load the JSON data in WPF DataGrid (SfDataGrid)?

This sample show cases how to load the JSON data in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The JSON data cannot be directly bound to the [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). To bind it, deserialize the JSON data to the bindable format. You can use the Newtonsoft.Json open source NuGet to serialize and deserialize the JSON objects.

The JSON data can be parsed into a DataTable collection using **JsonConvert.DeSerializeObject<List<Dictionary<string, object>>(json_object)**.

You can convert the list dictionary objects to the `ObservableCollection` if your data source should respond the collection changes.
