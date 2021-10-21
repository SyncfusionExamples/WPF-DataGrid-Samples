# How to set row height based on content while printing WPF DataGrid (SfDataGrid)?

This sample show cases how to set the row height based on the content while printing [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

You can set the row height based on content while printing [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) by extending the [GridPrintManager](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridPrintManager.html) class and overriding the GetRowHeight method in it. 

You can set the instance of the extended [GridPrintManager](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridPrintManager.html) to the [SfDatagrid.PrintSettings.PrintManagerBase](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.PrintSettings.html#Syncfusion_UI_Xaml_Grid_PrintSettings_PrintManagerBase) in the **SfDataGrid.Loaded** event.

KB article - [How to set row height based on content while printing WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/7764/how-to-set-row-height-based-on-content-while-printing-wpf-datagrid-sfdatagrid)
