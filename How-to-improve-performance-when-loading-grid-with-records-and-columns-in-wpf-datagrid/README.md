# How to improve performance when loading grid with records and columns in WPF DataGrid (SfDataGrid)?

This sample show cases how to improve the performance when loading the grid with more records and columns in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The loading performance of [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) can be improved in following ways to provide better performance when loading millions of records with 1000+ columns,

1. Set `EnableDataVirtualization` as `true` for improving loading and data operations performance, where DataGrid will get loaded and process the data immediately regardless of number of records.

2. Set `UseDrawing` property for improving loading and scrolling performance, where SfDataGrid cells drawn instead of loading TextBlock. This option can be used when you are loading more number of cells in View. For examples, you can use this when view displays 40 rows and more than 30 columns. 

KB article - [How to improve performance when loading grid with records and columns in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/7752/how-to-improve-performance-when-loading-grid-with-records-and-columns-in-wpf-datagrid)
