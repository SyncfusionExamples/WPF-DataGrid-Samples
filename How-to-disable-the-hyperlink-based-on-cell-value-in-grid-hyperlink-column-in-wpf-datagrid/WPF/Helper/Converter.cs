using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SfDataGridDemo
{
    public class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var data = (value as GridCell).ColumnBase as DataColumnBase;
            var columnName = data.GridColumn.MappingName;
            if (data.GridColumn is GridHyperlinkColumn && columnName == "EmployeeArea")
            {
                var gridCell = value as GridCell;
                var getDataContext = gridCell.DataContext as Model;
                //Disable HyperLinkColumn column based on Review column false value.
                var getProperty = getDataContext.Review;
                return getProperty;
            }
            return true;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
