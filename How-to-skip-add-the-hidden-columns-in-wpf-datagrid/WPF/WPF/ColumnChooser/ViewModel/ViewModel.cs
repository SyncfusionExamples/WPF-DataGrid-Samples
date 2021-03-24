#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
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
using Syncfusion.Windows.Controls.Grid;
using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;


namespace ColumnChooserDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> orderCollection;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderCollection; }
            set { orderCollection = value; }
        }
        #region Delegate Command

        public DelegateCommand<object> _ColumnChooserCommand;

        /// <summary>
        /// Gets the column chooser command.
        /// </summary>
        /// <value>The column chooser command.</value>
        public DelegateCommand<object> ColumnChooserCommand
        {
            get { return _ColumnChooserCommand; }
            set { _ColumnChooserCommand = value; }
        }

        #endregion
        public ViewModel()
        {
            orderCollection = new ObservableCollection<OrderInfo>();
            OrderInfoCollection = GenerateOrders1();
        }

        public ObservableCollection<OrderInfo> GenerateOrders1()
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();
            orders.Add(new OrderInfo(1001, "Bulk", "Beverton", "ALFKI", "US"));
            orders.Add(new OrderInfo(1002, "Oliver", "Oregon", "ANATR", "us"));
            orders.Add(new OrderInfo(1003, "Brendon", "Johanesberg", "ANTON", "China"));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "YHGTR", "UK"));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US"));
            orders.Add(new OrderInfo(1007, "Friedo", "Britain", "YTREW", "US"));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Mumbai"));
            orders.Add(new OrderInfo(1009, "Sirert", "Bulk", "BGFDE", "US"));
            orders.Add(new OrderInfo(1010, "Rakesh", "hertion", "BOTTM", "Britain"));
            orders.Add(new OrderInfo(1011, "George", "Oregon", "TGVFD", "US"));
            orders.Add(new OrderInfo(1004, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "Bulk", "UK"));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US"));
            orders.Add(new OrderInfo(1007, "Friedo", "James", "YTREW", "US"));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Bulk"));
            return orders;
        }

        private bool showColumnChooser = true;

        public bool ShowColumnChooser
        {
            get { return showColumnChooser; }
            set { showColumnChooser = value; }
        }

        private bool useDefaultColumnChooser = true;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool UseDefaultColumnChooser
        {
            get { return useDefaultColumnChooser; }
            set { useDefaultColumnChooser = value; }
        }


        public class CustomColumnChooserViewModel : NotificationObject
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CustomColumnChooserViewModel"/> class.
            /// </summary>
            /// <param name="totalColumns">The total columns.</param>
            public CustomColumnChooserViewModel(ObservableCollection<OrderInfo> totalColumns)
            {
                ColumnCollection = totalColumns;
            }

            /// <summary>
            /// Gets or sets the column collection.
            /// </summary>
            /// <value>The column collection.</value>
            public ObservableCollection<OrderInfo> ColumnCollection
            {
                get;
                set;
            }
        }
    }
}
