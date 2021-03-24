using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Cells;
using System;
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
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using Syncfusion.Data;
using System.Collections.ObjectModel;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.FilterItemsPopulated += grid_FilterItemsPopulated;
            this.dataGrid.FilterChanging += grid_FilterChanging;
        }

        void grid_FilterChanging(object sender, GridFilterEventArgs e)
        {
            if (e.FilterPredicates == null || e.Column.MappingName != "Review" || e.FilterPredicates.Count == 0)
                return;

            //once the filter is applied, we need to change the filtervalue as original instead the changed value in filteritemspopulated event.
            if (e.FilterPredicates[0].FilterValue.Equals("Reviewed"))
                e.FilterPredicates[0].FilterValue = true;
            else if (e.FilterPredicates[0].FilterValue.Equals("NotReviewed"))
                e.FilterPredicates[0].FilterValue = false;
        }

        void grid_FilterItemsPopulated(object sender, GridFilterItemsPopulatedEventArgs e)
        {
            if (e.Column.MappingName == "Review")
            {
                var itemsSource = e.ItemsSource as List<FilterElement>;

                //true changed into "Reviewed" and false changed into "NotReviewed" for localization.
                foreach (var element in itemsSource)
                {
                    if (element.ActualValue.Equals(true))
                        element.ActualValue = "Reviewed";
                    else if (element.ActualValue.Equals(false))
                        element.ActualValue = "NotReviewed";
                }
            }
        }            
    }
}
         
   

