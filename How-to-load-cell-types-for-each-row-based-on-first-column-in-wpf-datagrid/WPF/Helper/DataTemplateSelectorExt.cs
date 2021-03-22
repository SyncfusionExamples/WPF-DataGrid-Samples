using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SfDataGridDemo
{
    public class DataTemplateSelectorExt : DataTemplateSelector
    {
        DataTemplate TextBoxTemplate;
        DataTemplate PercentTemplate;
        DataTemplate DoubleTemplate;
        DataTemplate CurrencyTemplate;
        DataTemplate UpdownTemplate;
        DataTemplate TextBlockTemplate;

        public DataTemplateSelectorExt()
        {
            TextBlockTemplate = App.Current.Resources["TextBlockTemplate"] as DataTemplate;
            TextBoxTemplate = App.Current.Resources["TextBoxTemplate"] as DataTemplate;
            PercentTemplate = App.Current.Resources["PercentTemplate"] as DataTemplate;
            DoubleTemplate = App.Current.Resources["DoubleTemplate"] as DataTemplate;
            CurrencyTemplate = App.Current.Resources["CurrencyTemplate"] as DataTemplate;
            UpdownTemplate = App.Current.Resources["UpdownTemplate"] as DataTemplate;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
                return TextBlockTemplate;
            DataContextHelper dataContextHelper = item as DataContextHelper;

            OrderInfo orderInfo = dataContextHelper.Record as OrderInfo;
            if (orderInfo == null)
                return TextBlockTemplate;

            switch (orderInfo.ProductName)
            {
                case "TextColumn":
                    return TextBoxTemplate;
                case "NumericColumn":
                    return PercentTemplate;
                case "DoubleTextBoxColumn":
                    return DoubleTemplate;
                case "CurrencyColumn":
                    return CurrencyTemplate;
                case "GridUpDownColumn":
                    return UpdownTemplate;
                default:
                    return TextBlockTemplate;
            }
        }
    }
}
