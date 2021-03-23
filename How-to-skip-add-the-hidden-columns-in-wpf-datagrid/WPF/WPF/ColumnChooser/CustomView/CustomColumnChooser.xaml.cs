#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Data.Extensions;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
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
using System.Windows.Shapes;

namespace ColumnChooserDemo.CustomView
{
    /// <summary>
    /// Interaction logic for CustomColumnChooser.xaml
    /// </summary>

    public partial class CustomColumnChooser : ChromelessWindow, IColumnChooser
    {
        #region Field

        /// <summary>
        /// Gets or sets the reference to the SfDataGrid instance for the Column Chooser.
        /// </summary>
        /// <value>
        /// The SfDataGrid instance.
        /// </value>       
        protected SfDataGrid DataGrid { get; set; }

        #endregion

        #region Dependency properties
        /// <summary>
        /// Gets or sets the water mark text for empty ColumnChooser window.
        /// </summary>
        /// <value>
        /// A string that displays the water mark text for column chooser window. The default value is <c>string.Empty</c>.
        /// </value>        
        public string WaterMarkText
        {
            get { return (string)GetValue(WaterMarkTextProperty); }
            set { SetValue(WaterMarkTextProperty, value); }
        }

        /// <summary>
        /// Identifies the Syncfusion.UI.Xaml.Grid.ColumnChooser.WaterMarkText dependency property.
        /// </summary>        
        /// <remarks>
        /// The identifier for the Syncfusion.UI.Xaml.Grid.ColumnChooser.WaterMarkText dependency property.
        /// </remarks>    
        public static readonly DependencyProperty WaterMarkTextProperty =
            DependencyProperty.Register("WaterMarkText", typeof(string), typeof(ColumnChooser), new PropertyMetadata(string.Empty));
        #endregion

        private IColumnChooser _columnchooser = null;
        #region Ctor
        /// <summary>
        /// Initializes a new instance of <see cref="Syncfusion.UI.Xaml.Grid.ColumnChooser"/> class.
        /// </summary>
        /// <param name="dataGrid">
        /// The SfDataGrid.
        /// </param>
        public CustomColumnChooser(SfDataGrid dataGrid)
        {
            InitializeComponent();
            this.DataGrid = dataGrid;
            this.DataContext = this;
            this.Title = GridResourceWrapper.ColumnChooserTitle;
            this.WaterMarkText = GridResourceWrapper.ColumnChooserWaterMark;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Builds the visual tree for the Column Chooser window when a new template is applied.
        /// </summary>
        public override void OnApplyTemplate()
        {
            this.DataGrid.Columns.ForEach(col =>
            {
                //You can Remove column When the isHidden property as true
                if (col.IsHidden)
                    RemoveChild(col);
            });
            base.OnApplyTemplate();
        }
        #endregion

        #region Virtual methods
        #region Child adding and removing

        /// <summary>
        /// Adds the specified column to the children of column chooser window.
        /// </summary>
        /// <param name="column">
        /// The corresponding column to add children for the column chooser window.
        /// </param>    
        /// 

        public virtual void AddChild(GridColumn column)
        {
            if (this.PART_ChooserPanel == null)
                return;
            if (this.PART_ChooserPanel.Children.ToList<ColumnChooserItem>().All(item => (item as ColumnChooserItem).Column.MappingName != column.MappingName) && this.DataGrid.View != null)
            {
                var chooserItem = new ColumnChooserItem(column);
                chooserItem.Controller = this.DataGrid.GridColumnDragDropController;
                chooserItem.ColumnName = column.HeaderText;
                this.PART_ChooserPanel.Children.Add(chooserItem);
            }
            if (this.PART_ChooserPanel.Children.Count == 0)
                this.ColumnChooserAreaText.Visibility = Visibility.Visible;
            else
                this.ColumnChooserAreaText.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Removes the specified child column from the column chooser window.
        /// </summary>
        /// <param name="column">
        /// The corresponding column to remove child from the column chooser window.
        /// </param>      
        public virtual void RemoveChild(GridColumn column)
        {
            if (this.PART_ChooserPanel != null && this.PART_ChooserPanel.Children.Count > 0)
            {
                var element = this.PART_ChooserPanel.Children.ToList<ColumnChooserItem>().FirstOrDefault(item => (item as ColumnChooserItem).Column.MappingName == column.MappingName);
                if (element != null)
                    this.PART_ChooserPanel.Children.Remove(element);
            }
            if (this.PART_ChooserPanel.Children.Count == 0)
                this.ColumnChooserAreaText.Visibility = Visibility.Visible;
            else
                this.ColumnChooserAreaText.Visibility = Visibility.Collapsed;
        }

        #endregion

        /// <summary>
        /// Gets the display rectangle for column chooser window.
        /// </summary>
        /// <returns>
        /// The display rectangle for column chooser window.
        /// </returns>        
        public virtual Rect GetControlRect()
        {
            var point = this.TranslatePoint(new Point(0, 0), this.DataGrid);

            var rect = new Rect(point.X, point.Y, this.ActualWidth, this.ActualHeight);
            return rect;
        }
        #endregion
    }
}