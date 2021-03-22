using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SfDataGridDemo
{
    public class GroupSummaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var groupRecords = ((value as SummaryRecordEntry).Parent as Group).Records;
            var underlyingData = groupRecords[0].Data as Employee;
            return "The employee name of corresponding employee id (" + underlyingData.EmployeeID + ") " + "is " + underlyingData.EmployeeName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
