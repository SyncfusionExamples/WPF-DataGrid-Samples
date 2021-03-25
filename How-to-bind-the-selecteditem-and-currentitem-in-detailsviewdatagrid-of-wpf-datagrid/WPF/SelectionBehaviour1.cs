using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace DetailsView_NestedLevel
{
    public class SelectionBehaviour : Behavior<SfDataGrid>
    {
        public object DetailsViewSelectedItem
        {
            get { return (object)GetValue(DetailsViewSelectedItemProperty); }
            set { SetValue(DetailsViewSelectedItemProperty, value); }
        }

        public static readonly DependencyProperty DetailsViewSelectedItemProperty =
            DependencyProperty.Register("DetailsViewSelectedItem", typeof(object), typeof(SelectionBehaviour), new PropertyMetadata(null));

        public object DetailsViewCurrentItem
        {
            get { return (object)GetValue(DetailsViewCurrentItemProperty); }
            set { SetValue(DetailsViewCurrentItemProperty, value); }
        }
        public static readonly DependencyProperty DetailsViewCurrentItemProperty =
           DependencyProperty.Register("DetailsViewCurrentItem", typeof(object), typeof(SelectionBehaviour), new PropertyMetadata(null));

        public ObservableCollection<object> DetailsViewSelectedItems
        {
            get { return (ObservableCollection<object>)GetValue(DetailsViewSelectedItemsProperty); }
            set { SetValue(DetailsViewSelectedItemsProperty, value); }
        }

        public static readonly DependencyProperty DetailsViewSelectedItemsProperty =
            DependencyProperty.Register("DetailsViewSelectedItems", typeof(ObservableCollection<object>), typeof(SelectionBehaviour), new PropertyMetadata(null));

        protected override void OnAttached()
        {           
            this.AssociatedObject.Loaded+=AssociatedObject_Loaded;
        }

        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            (this.AssociatedObject.DetailsViewDefinition[0] as GridViewDefinition).DataGrid.SelectionChanged += FirstDetailsViewDataGridSelectionChanged;          
        }
        public Object ViewCurrentItem
        {
            get { return (Object)GetValue(ViewCurrentItemProperty); }
            set { SetValue(ViewCurrentItemProperty, value); }
        }

        public static readonly DependencyProperty ViewCurrentItemProperty =
            DependencyProperty.Register("ViewCurrentItem", typeof(Object), typeof(SelectionBehaviour), new PropertyMetadata(null));
       
        void FirstDetailsViewDataGridSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            this.DetailsViewSelectedItem = (e.OriginalSender as SfDataGrid).SelectedItem;
            this.DetailsViewSelectedItems = (e.OriginalSender as SfDataGrid).SelectedItems;
            this.DetailsViewCurrentItem = (e.OriginalSender as SfDataGrid).CurrentItem;
        }
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= AssociatedObject_Loaded;
        }
    }
}
