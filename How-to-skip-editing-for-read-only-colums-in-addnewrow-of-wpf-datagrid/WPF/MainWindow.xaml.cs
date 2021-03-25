using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        public MainWindow()
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

                //property is readonly you can cancel the editing of the cell.
                if (propertyInfo.IsReadOnly)
                {
                    args.Cancel = true;
                }
            }
        }
    }
}
         
   

