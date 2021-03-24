using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfTestingSample
{
    
    public class CustomRowStyleMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var dataContext = (values[1] as VirtualizingCellsControl).DataContext;
            if ((bool)values[0] == null)
                return DependencyProperty.UnsetValue;
            if ((bool)values[0])
                return new SolidColorBrush(Colors.Green) { Opacity = 0.7 };
            return DependencyProperty.UnsetValue;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
  
}
