using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            this.datagrid.CurrentCellValueChanged += datagrid_CurrentCellValueChanged;
        }

        public void datagrid_CurrentCellValueChanged(object sender, CurrentCellValueChangedEventArgs args)
        {
            int columnindex = datagrid.ResolveToGridVisibleColumnIndex(args.RowColumnIndex.ColumnIndex);
            var column = datagrid.Columns[columnindex];
            if (column is GridCheckBoxColumn)
            {
                var rowIndex = this.datagrid.ResolveToRecordIndex(args.RowColumnIndex.RowIndex);
                RecordEntry record = null;
                if (this.datagrid.GroupColumnDescriptions.Count == 0)
                {
                    record = this.datagrid.View.Records[rowIndex] as RecordEntry;
                }
                else
                {
                    record = (this.datagrid.View.TopLevelGroup.DisplayElements[rowIndex] as RecordEntry);
                }
                //Checkbox property changed value is stored here.
                var value = (record.Data as Model).Review;
            }
        }
    }
}
