using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo.CustomManagerBase
{
    public class CustomPrintManager : GridPrintManager
    {
        SfDataGrid dataGrid;
        GridRowSizingOptions gridRowSizingOptions = new GridRowSizingOptions();
        double Height = double.NaN;
        public CustomPrintManager(SfDataGrid grid)
            : base(grid)
        {
            dataGrid = grid;
        }

        protected override double GetRowHeight(object record, int rowindex, RowType rowtype)
        {
            if (record != null && rowtype == RowType.DefaultRow)
            {

                if (this.dataGrid.GridColumnSizer.GetAutoRowHeight(record, gridRowSizingOptions, out Height))
                    if (Height > 24)
                        return Height;
            }
            return base.GetRowHeight(record, rowindex, rowtype);
        }
    }
}
