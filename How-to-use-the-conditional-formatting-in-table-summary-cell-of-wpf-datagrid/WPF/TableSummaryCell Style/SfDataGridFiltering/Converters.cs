using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace SfDataGridFiltering
{
    public class StyleConverter : IValueConverter
    {
        GridTableSummaryCell gridtablesummarycell;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            gridtablesummarycell = value as GridTableSummaryCell;

            var data = gridtablesummarycell.DataContext as SummaryRecordEntry;

            if (gridtablesummarycell.ColumnBase.ColumnIndex == 1)
            {
                if ((int)data.SummaryValues[0].AggregateValues.ElementAt(0).Value > 0)
                    return Brushes.Red;
                else
                    return Brushes.Blue;
            }

            else if (gridtablesummarycell.ColumnBase.ColumnIndex == 2)
            {

                if ((int)data.SummaryValues[1].AggregateValues.ElementAt(0).Value > 0)
                    return Brushes.Red;
                else
                    return Brushes.Blue;
            }

            else if (gridtablesummarycell.ColumnBase.ColumnIndex == 5)
            {

                if ((int)data.SummaryValues[2].AggregateValues.ElementAt(0).Value > 0)
                    return Brushes.Red;           
                else
                    return Brushes.Blue;
            }
            return Brushes.Black;
        }        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }       
}


