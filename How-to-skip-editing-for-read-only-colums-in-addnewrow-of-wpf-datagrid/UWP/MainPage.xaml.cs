using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.grid.CurrentCellBeginEdit += grid_CurrentCellBeginEdit;
        }

        void grid_CurrentCellBeginEdit(object sender, CurrentCellBeginEditEventArgs args)
        {
            var rowIndex = args.RowColumnIndex.RowIndex;

            //If the rowindex in AddNewRowIndex, we need to validate whether the property is readonly or not.
            if (this.grid.IsAddNewIndex(rowIndex))
            {
                //pdc - PropertyDescriptorCollection.
                var pdc = this.grid.View.GetItemProperties();

                //get the propertyinfo from PropertyDescriptorCollection. 
                var propertyInfo = pdc.Find(args.Column.MappingName, true);

                //If property is readonly, you can cancel the editing of the cell.
                if (propertyInfo.CanRead)
                {
                    args.Cancel = true;
                }
            }
        }
    }
}
