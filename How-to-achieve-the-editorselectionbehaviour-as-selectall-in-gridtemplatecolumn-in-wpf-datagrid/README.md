# How to achieve the EditorSelectionBehaviour as SelectAll in GridTemplateColumn in WPF DataGrid (SfDataGrid)?

This sample show cases how to achieve the EditorSelectionBehavior as SelectAll in [GridTemplateColumn](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTemplateColumn.html) in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid).

The [EditorSelectionBehavior](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.EditorSelectionBehavior.html) as [SelectAll](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.SfDataGrid.html#Syncfusion_UI_Xaml_Grid_SfDataGrid_SelectAll_System_Boolean_) will not work when the [GridTemplateColumn](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.GridTemplateColumn.html) is in edit mode in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid). Because, the element loaded inside the edit template cannot be predicted. You can achieve this by programmatically selecting all the text whenever the edit element got focus.

KB article - [How to achieve the EditorSelectionBehaviour as SelectAll in GridTemplateColumn in WPF DataGrid (SfDataGrid)?](https://www.syncfusion.com/kb/9292/how-to-achieve-the-editorselectionbehaviour-as-selectall-in-gridtemplatecolumn-in-wpf)
