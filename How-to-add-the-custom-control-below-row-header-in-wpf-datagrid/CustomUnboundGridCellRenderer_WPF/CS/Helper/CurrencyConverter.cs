using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UnBoundRowDemo
{
   public class CurrencyConverter :IValueConverter
    {
     
       public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
       {
           var model = value as SalesByYear;
           //converts the currency rate of India to USA
           if (parameter != null && parameter.ToString() == "USA")
           {
               return "$" + "" + (double)model.QS2 / 60;
           }
            //converts the currency rate of USA to India
           else if(parameter!=null && parameter.ToString()=="India")
           {
                return "₹" + "" + (double)model.QS2 * 60;
               
           }
           else
             return (double)model.QS2;
       }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
