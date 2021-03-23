using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {       
        public MainPage()
        {
            this.InitializeComponent();
            this.dataGrid.Loaded += DataGrid_Loaded;
        }
        private static readonly List<string> DateFilterColumnsName = new List<string> { "ShipDate", "OrderDate" };
        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.dataGrid.FilterItemsPopulated += DataGrid_FilterItemsPopulated;
        }

        private void DataGrid_FilterItemsPopulated(object sender, Syncfusion.UI.Xaml.Grid.GridFilterItemsPopulatedEventArgs e)
        {
            if (DateFilterColumnsName.Contains(e.Column.MappingName))
            {
                e.FilterControl.OkButtonClick += FilterControl_OkButtonClick;
                var itemsSource = e.ItemsSource as List<FilterElement>;
                foreach (var a in itemsSource)
                {
                    var actualValue = (DateTime)a.ActualValue;
                    a.DisplayText = actualValue.ToString("dd MMMM yyyy", CultureInfo.CurrentCulture);
                }
            }
        }

        IEnumerable<FilterElement> checkedItems = null;
        IEnumerable<FilterElement> unCheckedItems = null;
        private void FilterControl_OkButtonClick(object sender, Syncfusion.UI.Xaml.Grid.OkButtonClikEventArgs e)
        {
            checkedItems = e.CheckedElements;
            unCheckedItems = e.UnCheckedElements;
            (sender as GridFilterControl).OkButtonClick -= FilterControl_OkButtonClick;
        }

        private void dataGrid_FilterChanging(object sender, GridFilterEventArgs e)
        {
            if (!DateFilterColumnsName.Contains(e.Column.MappingName))
                return;            
            if (e.FilterPredicates == null)
                return;
            //Due to performance reasons in SfDataGrid FilterPredicates are created based on Checked and UnChecked items count (Which count is less)
            //so need to change the FilterPredicates after changing DisplayText of FilterElement.
            if (checkedItems.Count() > unCheckedItems.Count())
            {
                e.FilterPredicates.Clear();
                var init = true;
                foreach (var filterelement in checkedItems)
                {
                    var c = new FilterPredicate();                   
                    c.FilterValue = filterelement.ActualValue;
                    c.FilterBehavior = FilterBehavior.StringTyped;
                    c.FilterType = Syncfusion.Data.FilterType.Contains;
                    c.PredicateType = init ? PredicateType.And : PredicateType.Or;
                    init = false;
                    e.FilterPredicates.Add(c);
                }
            }          
        }
    }
}
