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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Utility;
using Syncfusion.UI.Xaml.Grid;

namespace Performance_SfDataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.SearchHelper = new SearchHelperExt(this.dataGrid);
            this.TextBox.LostFocus += TextBox_LostFocus;
            this.TextBox.PreviewKeyDown += TextBox_PreviewKeyDown;
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PerformSearch();
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                PerformSearch();
        }

        private void PerformSearch()
        {
            if (this.dataGrid.SearchHelper.SearchText.Equals(this.TextBox.Text))
                return;

            var text = TextBox.Text;
            //AllowCaseSensitiveSearch  - true -> improves the performance when search numeric fields.
            this.dataGrid.SearchHelper.AllowCaseSensitiveSearch = true;
            this.dataGrid.SearchHelper.SearchType = SearchType.StartsWith;
            this.dataGrid.SearchHelper.AllowFiltering = true;
            this.dataGrid.SearchHelper.Search(text);
        }
    }
}
