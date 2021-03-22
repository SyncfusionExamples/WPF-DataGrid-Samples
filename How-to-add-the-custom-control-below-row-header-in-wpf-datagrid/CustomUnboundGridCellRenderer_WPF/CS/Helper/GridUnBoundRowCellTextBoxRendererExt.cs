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

namespace UnBoundRowDemo
{
    public class GridUnBoundRowCellTextBoxRendererExt : GridUnBoundRowCellRenderer<TextBlock, ComboBox>
    {
        public GridUnBoundRowCellTextBoxRendererExt()
        {

        }
        protected override TextBlock OnCreateDisplayUIElement()
        {
            return new TextBlock();
        }

        /// <summary>
        /// Edit Element creation.
        /// </summary>
        /// <returns></returns>
        protected override ComboBox OnCreateEditUIElement()
        {
            return new ComboBox();
        }
        public override void OnInitializeDisplayElement(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
        {
            uiElement.Text = dataColumn.GridUnBoundRowEventsArgs.Value.ToString();
        }

        /// <summary>
        /// Updates the value for display element.
        /// </summary>
        /// <param name="dataColumn"></param>
        /// <param name="uiElement"></param>
        /// <param name="dataContext"></param>
        public override void OnUpdateDisplayBinding(DataColumnBase dataColumn, TextBlock uiElement, object dataContext)
        {
            uiElement.Text = dataColumn.GridUnBoundRowEventsArgs.Value.ToString();
        }
        #region Edit Element

        protected override void OnWireEditUIElement(ComboBox uiElement)
        {
             uiElement.SelectionChanged+=uiElement_SelectionChanged;
            base.OnWireEditUIElement(uiElement);
        }
     
        /// <summary>
        /// Initialize the value for edit element.
        /// </summary>
        /// <param name="dataColumn"></param>
        /// <param name="uiElement"></param>
        /// <param name="dataContext"></param>

        public override void OnInitializeEditElement(DataColumnBase dataColumn, ComboBox uiElement, object dataContext)
        {
            List<string> itemsCollection = new List<string>();
            itemsCollection.Add("India");
            itemsCollection.Add("USA");
            uiElement.ItemsSource = itemsCollection; 
            
            if(dataColumn.GridUnBoundRowEventsArgs.Value!=null)
                uiElement.SelectedValue = dataColumn.GridUnBoundRowEventsArgs.Value.ToString();
            uiElement.Tag = dataColumn;              
        }

        void uiElement_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                if (comboBox != null && comboBox.SelectedItem != null)
                {
                    (DataGrid.DataContext as SalesInfoViewModel).DisplayValue = comboBox.SelectedItem.ToString();
                    (comboBox.Tag as DataColumnBase).GridUnBoundRowEventsArgs.Value = comboBox.SelectedItem.ToString();
                    DataGrid.RaiseQueryUnBoundRow((comboBox.Tag as DataColumnBase).GridUnBoundRowEventsArgs.GridUnboundRow, UnBoundActions.CommitData, (comboBox.Tag as DataColumnBase).GridUnBoundRowEventsArgs.Value, (comboBox.Tag as DataColumnBase).GridColumn, (comboBox.Tag as DataColumnBase).GridUnBoundRowEventsArgs.CellType, new Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex((comboBox.Tag as DataColumnBase).RowIndex, (comboBox.Tag as DataColumnBase).ColumnIndex));
                }
            }
        }
        public override void OnUpdateEditBinding(DataColumnBase dataColumn, ComboBox element, object dataContext)
        {            
           var displayValue = (DataGrid.DataContext as SalesInfoViewModel).DisplayValue;                        
            element.SelectedValue = displayValue;            
        }
        #endregion
        #region Update

        /// <summary>
        /// Update display value and raise event
        /// </summary>
        /// <param name="dataColumn"></param>
        /// <param name="currentRendererElement"></param>
        protected override void OnEditingComplete(DataColumnBase dataColumn, FrameworkElement currentRendererElement)
        {
            dataColumn.GridUnBoundRowEventsArgs.Value = (currentRendererElement as ComboBox).SelectedValue;
            DataGrid.RaiseQueryUnBoundRow(dataColumn.GridUnBoundRowEventsArgs.GridUnboundRow, UnBoundActions.CommitData, dataColumn.GridUnBoundRowEventsArgs.Value, dataColumn.GridColumn, dataColumn.GridUnBoundRowEventsArgs.CellType, new Syncfusion.UI.Xaml.ScrollAxis.RowColumnIndex(dataColumn.RowIndex, dataColumn.ColumnIndex));
        }
        #endregion
        protected override void OnUnwireEditUIElement(ComboBox uiElement)
        {
            uiElement.SelectionChanged -= uiElement_SelectionChanged;
            base.OnUnwireEditUIElement(uiElement);
        }


    }

}
