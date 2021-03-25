using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace TableSummary_CellStyle
{
    public class TableSummaryStyleSelector : StyleSelector
    {
        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            var data = (SummaryRecordEntry)item;
            if ((int)data.SummaryValues[0].AggregateValues.ElementAt(0).Value > 0)
                return App.Current.Resources["TableSummaryStyle1"] as Style;
            return App.Current.Resources["TableSummaryStyle2"] as Style;
        }      
    }
}
