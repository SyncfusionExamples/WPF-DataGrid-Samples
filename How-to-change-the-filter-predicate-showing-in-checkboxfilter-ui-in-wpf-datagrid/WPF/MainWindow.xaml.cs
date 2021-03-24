using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid.Helpers;
using SfDataGrid_ComboBoxDemo;
using System.Collections.ObjectModel;
using Syncfusion.Data;
using System.Globalization;

namespace SfDataGrid_ComboBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.Loaded += dataGrid_Loaded;
        }
        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.dataGrid.FilterItemsPopulated += dataGrid_FilterItemsPopulated;          
        }

        private static readonly List<string> FilterColumnsName = new List<string> { "ShipDate", "OrderDate" };

        private void dataGrid_FilterItemsPopulated(object sender, GridFilterItemsPopulatedEventArgs e)
        {          
            if (FilterColumnsName.Contains(e.Column.MappingName))
            {              
                e.FilterControl.OkButtonClick += FilterControl_OkButtonClick;
                var itemsSource = e.ItemsSource as List<FilterElement>;              
                foreach (var a in itemsSource)
                {
                    var actualValue = (DateTime)a.ActualValue;
                    //you can change the DisplayText of FilterElement here.
                    a.DisplayText = actualValue.ToString("dd MMMM yyyy", CultureInfo.CurrentCulture);                 
                }              
            }
        }

        IEnumerable<FilterElement> checkedItems = null;
        IEnumerable<FilterElement> unCheckedItems = null;
        private void FilterControl_OkButtonClick(object sender, OkButtonClikEventArgs args)
        {
            checkedItems = args.CheckedElements;
            unCheckedItems = args.UnCheckedElements;
            (sender as GridFilterControl).OkButtonClick -= FilterControl_OkButtonClick;
        }

        private void dataGrid_FilterChanging(object sender, GridFilterEventArgs e)
        {
            if (!FilterColumnsName.Contains(e.Column.MappingName))
                return;           
            if (e.FilterPredicates == null)
                return;
            //Due to performance reasons in SfDataGrid FilterPredicates are created based on Checked and UnChecked items count (Which count is less)
            //so need to change the FilterPredicates after changing DisplayText of FilterElement.
            if (checkedItems.Count() > unCheckedItems.Count())
            {
                e.FilterPredicates.Clear();
                var init = true;
                foreach (var filterElement in checkedItems)
                {
                    var c = new FilterPredicate();                    
                    c.FilterValue = filterElement.ActualValue;
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
