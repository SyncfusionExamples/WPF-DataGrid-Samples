using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Xaml.Data;

namespace SfDataGridDemo
{
   public class IconConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {           
            var record = value as Model; 
            //Loading Image based on GridCell value.           
            var image=(record.ShowCellIcon) ? "Images/yes.png" : "Images/no.png";           
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }      
    }
}
