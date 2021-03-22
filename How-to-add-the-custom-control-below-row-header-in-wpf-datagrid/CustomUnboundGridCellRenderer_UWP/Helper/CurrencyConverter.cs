using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace SfDataGridDemo
{
   public class CurrencyConverter :IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            var model = value as Employee;
            //converts the currency rate of India to USA
            if (parameter != null && parameter.ToString() == "USA")
            {
                return "$" + "" + (double)model.Salary / 60;
            }
            //converts the currency rate of USA to India
            else if (parameter != null && parameter.ToString() == "India")
            {
                return "₹" + "" + (double)model.Salary * 60;

            }
            else
                return (double)model.Salary;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            throw new NotImplementedException();
        }
    }
}
