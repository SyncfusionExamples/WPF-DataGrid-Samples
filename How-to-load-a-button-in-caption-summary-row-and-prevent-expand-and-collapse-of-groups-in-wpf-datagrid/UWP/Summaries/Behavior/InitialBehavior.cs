using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfDataGridDemo.ViewModel;
using System.Collections.ObjectModel;
using static SfDataGridDemo.ViewModel.ViewModel;
using Syncfusion.PMML;
using SfDataGridDemo.Model;

namespace SfDataGridDemo.Behavior
{
    public class InitialBehavior : Behavior<MainPage>
    {
        ColumnChooser chooserWindow;

        #region Overrides

        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += OnAssociatedObjectLoaded;
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= OnAssociatedObjectLoaded;
            base.OnDetaching();
        }

        #endregion

        ViewModel viewModel;

        void OnAssociatedObjectLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            viewModel = (this.AssociatedObject.DataContext) as ViewModel;
            viewModel.ColumnChooserCommand = new DelegateCommand<object>(ColumnChooserCommandHandler);
            InitializeColumnChooserPopup();
        }

        public void ColumnChooserCommandHandler(object param)
        {
            if (param == null)
                ShowColumnChooser();
            else if (param.ToString().Equals("ShowColumnChooser"))
            {
                if (viewModel.ShowColumnChooser)
                    ShowColumnChooser();
                else
                    chooserWindow.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        void ShowColumnChooser()
        {
            if (viewModel.ShowColumnChooser && viewModel.UseDefaultColumnChooser)
                chooserWindow.Visibility = System.Windows.Visibility.Visible;
            else
            {
                if (!viewModel.ShowColumnChooser)
                    return;
                var visibleColumns = this.AssociatedObject.dataGrid.Columns;
                ObservableCollection<OrderInfo> totalColumns = GetColumnsDetails(visibleColumns);
                CustomColumnChooserViewModel chooserViewModel = new CustomColumnChooserViewModel(totalColumns);
                CustomColumnChooser ColumnChooserView = new CustomColumnChooser(chooserViewModel);
                ColumnChooserView.Owner = Application.Current.MainWindow;
                chooserWindow.Visibility = System.Windows.Visibility.Collapsed;
                if ((bool)ColumnChooserView.ShowDialog())
                    ClickOKButton(chooserViewModel.ColumnCollection, this.AssociatedObject.dataGrid);
                viewModel.ShowColumnChooser = false;
            }
        }

        void InitializeColumnChooserPopup()
        {
            chooserWindow = new ColumnChooser(this.AssociatedObject.dataGrid);
            chooserWindow.Resources.MergedDictionaries.Clear();
            chooserWindow.ClearValue(ColumnChooser.StyleProperty);
            chooserWindow.Resources.MergedDictionaries.Add(this.AssociatedObject.MainGrid.Resources.MergedDictionaries[0]);
            this.AssociatedObject.dataGrid.GridColumnDragDropController = new GridColumnChooserController(this.AssociatedObject.dataGrid, chooserWindow);
            chooserWindow.ShowColumnChooser();
            chooserWindow.Owner = this.AssociatedObject;
            chooserWindow.Closing += chooserWindow_Closing;
        }

        void chooserWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            chooserWindow.Visibility = System.Windows.Visibility.Collapsed;
            viewModel.ShowColumnChooser = false;
        }

        public void ClickOKButton(ObservableCollection<OrderInfo> ColumnCollection, SfDataGrid dataGrid)
        {
            foreach (var item in ColumnCollection)
            {
                var column = dataGrid.Columns.FirstOrDefault(v => v.MappingName == item.Name);
                if (column != null)
                {
                    if (item.IsChecked == false && !column.IsHidden)
                        column.IsHidden = true;
                    else if (item.IsChecked == true && column.IsHidden == true)
                    {
                        if (column.Width == 0)
                            column.Width = 150;
                        column.IsHidden = false;
                    }
                }
            }
            viewModel.ShowColumnChooser = false;
        }

        public static ObservableCollection<OrderInfo> GetColumnsDetails(Columns totalVisibleColumns)
        {
            ObservableCollection<OrderInfo> totalColumns = new ObservableCollection<OrderInfo>();
            foreach (var actualColumn in totalVisibleColumns)
            {
                OrderInfo item = new OrderInfo();
                if (actualColumn.IsHidden)
                {
                    item.IsChecked = false;
                    item.Name = actualColumn.MappingName;
                }
                else
                {
                    item.IsChecked = true;
                    item.Name = actualColumn.MappingName;
                }
                totalColumns.Add(item);
            }
            return totalColumns;
        }
    }
}
