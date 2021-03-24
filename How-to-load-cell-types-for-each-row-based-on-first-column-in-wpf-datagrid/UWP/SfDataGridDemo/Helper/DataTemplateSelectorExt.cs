using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SfDataGridDemo
{
    public class DataTemplateSelectorExt : DataTemplateSelector
    {
        DataTemplate TextBoxTemplate;
        DataTemplate DoubleTemplate;
        DataTemplate UpdownTemplate;
        DataTemplate TextBlockTemplate;

        public DataTemplateSelectorExt()
        {
            TextBlockTemplate = App.Current.Resources["TextBlockTemplate"] as DataTemplate;
            TextBoxTemplate = App.Current.Resources["TextBoxTemplate"] as DataTemplate;
            DoubleTemplate = App.Current.Resources["DoubleTemplate"] as DataTemplate;
            UpdownTemplate = App.Current.Resources["UpdownTemplate"] as DataTemplate;
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
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
                case "DoubleTextBoxColumn":
                    return DoubleTemplate;
                case "GridUpDownColumn":
                    return UpdownTemplate;
                default:
                    return TextBlockTemplate;
            }
        }
    }
}
