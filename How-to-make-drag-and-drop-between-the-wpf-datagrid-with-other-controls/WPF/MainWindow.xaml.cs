#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using RowDragAndDropBetweenControlsDemo.Model;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.Windows.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace RowDragAndDropBetweenControlsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            this.sfDataGrid.RowDragDropController = new GridRowDragDropControllerExt();
            this.listView.DragOver += ListView_DragOver;
            this.listView.PreviewMouseMove += ListView_PreviewMouseMove;
            this.listView.Drop += ListView_Drop;
        }

        /// <summary>
        /// to add the dropped records in the ListView control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_Drop(object sender, DragEventArgs e)
        {
            foreach (var item in records)
            {
                this.sfDataGrid.View.Remove(item as Orders);

                (this.DataContext as ViewModel).OrderDetails1.Add(item as Orders);
            }
        }

        /// <summary>
        /// to select and dragged the record from ListView to other control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ListBox dragSource = null;
                var records = new ObservableCollection<object>();
                ListBox parent = (ListBox)sender;
                dragSource = parent;
                object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

                records.Add(data);

                var dataObject = new DataObject();
                dataObject.SetData("ListViewRecords", records);
                dataObject.SetData("ListView", listView);

                if (data != null)
                {
                    DragDrop.DoDragDrop(parent, dataObject, DragDropEffects.Move);
                }

            }
            e.Handled = true;
        }
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);
                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }
                    if (element == source)
                    {
                        return null;
                    }
                }
                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }
            return null;
        }

        ObservableCollection<object> records = new ObservableCollection<object>();

        /// <summary>
        /// to move the dragged items form the ListView control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Records"))
                records = e.Data.GetData("Records") as ObservableCollection<object>;
        }

    }
   
    public class GridRowDragDropControllerExt : GridRowDragDropController
    {
        ObservableCollection<object> draggingRecords = new ObservableCollection<object>();

        /// <summary>
        /// Occurs when the input system reports an underlying dragover event with this element as the potential drop target.
        /// </summary>
        /// <param name="args">An <see cref="T:Windows.UI.Xaml.DragEventArgs">DragEventArgs</see> that contains the event data.</param>
        /// <param name="rowColumnIndex">Specifies the row column index based on the mouse point.</param>
        protected override void ProcessOnDragOver(DragEventArgs args, RowColumnIndex rowColumnIndex)
        {
            if (args.Data.GetDataPresent("ListViewRecords"))
                draggingRecords = args.Data.GetData("ListViewRecords") as ObservableCollection<object>;
            else
                draggingRecords = args.Data.GetData("Records") as ObservableCollection<object>;

            if (draggingRecords == null)
                return;

            //To get the dropping position of the record
            var dropPosition = GetDropPosition(args, rowColumnIndex, draggingRecords);

            //To Show the draggable popup with the DropAbove/DropBelow message
            ShowDragDropPopup(dropPosition, draggingRecords, args);
            //To Show the up and down indicators while dragging the row
            ShowDragIndicators(dropPosition, rowColumnIndex, args);

            args.Handled = true;
        }

        ListView listview;

        /// <summary>
        /// Occurs when the input system reports an underlying drop event with this element as the drop target.
        /// </summary>
        /// <param name="args">An <see cref="T:Windows.UI.Xaml.DragEventArgs">DragEventArgs</see> that contains the event data.</param>
        /// <param name="rowColumnIndex">Specifies the row column index based on the mouse point.</param>
        protected override void ProcessOnDrop(DragEventArgs args, RowColumnIndex rowColumnIndex)
        {
            if (args.Data.GetDataPresent("ListView"))
                listview = args.Data.GetData("ListView") as ListView;

            if (!DataGrid.SelectionController.CurrentCellManager.CheckValidationAndEndEdit())
                return;

            //To get the dropping position of the record
            var dropPosition = GetDropPosition(args, rowColumnIndex, draggingRecords);
            if (dropPosition == DropPosition.None)
                return;

            // to get the index of dropping record
            var droppingRecordIndex = this.DataGrid.ResolveToRecordIndex(rowColumnIndex.RowIndex);

            if (droppingRecordIndex < 0)
                return;

            // to insert the dragged records based on dropping records index 
            foreach (var record in draggingRecords)
            {
                if (listview != null)
                {
                    (listview.ItemsSource as ObservableCollection<Orders>).Remove(record as Orders);
                    var sourceCollection = this.DataGrid.View.SourceCollection as IList;

                    if(dropPosition==DropPosition.DropBelow)
                        sourceCollection.Insert(droppingRecordIndex+1, record);
                    else
                        sourceCollection.Insert(droppingRecordIndex, record);
                }
                else
                {
                    var draggingIndex = this.DataGrid.ResolveToRowIndex(draggingRecords[0]);

                    if (draggingIndex < 0)
                    {
                        return;
                    }

                    // to get the index of dragging row
                    var recordindex = this.DataGrid.ResolveToRecordIndex(draggingIndex);
                    // to ger the record based on index
                    var recordEntry = this.DataGrid.View.Records[recordindex];
                    this.DataGrid.View.Records.Remove(recordEntry);

                    // to insert the dragged records to particular position
                    if (draggingIndex < rowColumnIndex.RowIndex && dropPosition == DropPosition.DropAbove)
                        this.DataGrid.View.Records.Insert(droppingRecordIndex - 1, this.DataGrid.View.Records.CreateRecord(record));
                    else if (draggingIndex > rowColumnIndex.RowIndex && dropPosition == DropPosition.DropBelow)
                        this.DataGrid.View.Records.Insert(droppingRecordIndex + 1, this.DataGrid.View.Records.CreateRecord(record));
                    else
                        this.DataGrid.View.Records.Insert(droppingRecordIndex, this.DataGrid.View.Records.CreateRecord(record));
                }
            }

            //Closes the Drag arrow indication all the rows
            CloseDragIndicators();
            //Closes the Drag arrow indication all the rows
            CloseDraggablePopUp();
        }
    }
}
