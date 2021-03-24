#region Copyright Syncfusion Inc. 2001 - 2014
// Copyright Syncfusion Inc. 2001 - 2014. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Grid;
using System.Data;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<string> _comboBoxItemsSource = new List<string>();
        Random r = new Random();
        private ObservableCollection<OrderInfo> _orderList = new ObservableCollection<OrderInfo>();

        /// <summary>
        /// Gets or sets the order list.
        /// </summary>
        /// <value>The order list.</value>
        public ObservableCollection<OrderInfo> OrderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }

        
        public string[] Column = new string[] { "NumericColumn", "GridUpDownColumn", "TextColumn" };
        
        public List<string> ComboBoxItemsSource
        {
            get { return new List<string>() { "NumericColumn", "GridUpDownColumn", "TextColumn" }; }
            set { _comboBoxItemsSource = value; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {           
            this.PopulateData();
        }
        
        /// Populates the data.
        /// </summary>
        private void PopulateData()
        {
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 2, ProductID = 3, City = "B", City1 = "A2" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 2, ProductID = 3, City = "B", City1 = "A2" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 3, ProductID = 4, City = "C", City1 = "A3" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 4, ProductID = 5, City = "D", City1 = "A4" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 5, ProductID = 62, City = "E", City1 = "A5" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 6, ProductID = 3, City = "F", City1 = "A6" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 7, ProductID = 23, City = "G", City1 = "A7" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 8, ProductID = 5, City = "H", City1 = "A8" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 9, ProductID = 23, City = "I", City1 = "A9" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 10, ProductID = 12, City = "J", City1 = "A1" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 11, ProductID = 54, City = "K", City1 = "A2" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 12, ProductID = 6, City = "L", City1 = "A3" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 13, ProductID = 6, City = "M", City1 = "A4" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 14, ProductID = 8, City = "N", City1 = "A5" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 15, ProductID = 5, City = "O", City1 = "A6" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 16, ProductID = 3, City = "P", City1 = "A7" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 1, ProductID = 15, City = "A", City1 = "A1" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 2, ProductID = 21, City = "B", City1 = "A2" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 3, ProductID = 23, City = "C", City1 = "A3" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 4, ProductID = 145, City = "D", City1 = "A4" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 5, ProductID = 12, City = "E", City1 = "A5" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 6, ProductID = 23, City = "F", City1 = "A6" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 7, ProductID = 64, City = "G", City1 = "A7" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 8, ProductID = 23, City = "H", City1 = "A8" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 9, ProductID = 34, City = "I", City1 = "A9" });
            _orderList.Add(new OrderInfo() { ProductName = Column[2], OrderID = 10, ProductID = 142, City = "J", City1 = "A1" });
            _orderList.Add(new OrderInfo() { ProductName = Column[0], OrderID = 11, ProductID = 12, City = "K", City1 = "A2" });
            _orderList.Add(new OrderInfo() { ProductName = Column[1], OrderID = 12, ProductID = 12, City = "L", City1 = "A3" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
