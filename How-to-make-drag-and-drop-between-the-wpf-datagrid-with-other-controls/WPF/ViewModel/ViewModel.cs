#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using RowDragAndDropBetweenControlsDemo.Model;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowDragAndDropBetweenControlsDemo
{
   public class ViewModel:NotificationObject
    {
        Northwind northWind;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {

            OrderDetails = this.GetOrdersDetails();
            OrderDetails1 = this.GetOrdersDetails();
        }

        private ObservableCollection<Orders> _orderDetails;
        private ObservableCollection<Orders> _orderDetails1;

        /// <summary>
        /// Gets or sets the employee info.
        /// </summary>
        /// <value>The employee info.</value>
        public ObservableCollection<Orders> OrderDetails
        {
            get
            {
                return _orderDetails;
            }
            set
            {
                _orderDetails = value;
                RaisePropertyChanged("OrderDetails");
            }
        }

        /// <summary>
        /// Gets or sets the employee info.
        /// </summary>
        /// <value>The employee info.</value>
        public ObservableCollection<Orders> OrderDetails1
        {
            get
            {
                return _orderDetails1;
            }
            set
            {
                _orderDetails1 = value;
                RaisePropertyChanged("OrderDetails1");
            }
        }

        /// <summary>
        /// Gets the employee info.
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Orders> GetOrdersDetails()
        {
            var ordersDetails = new ObservableCollection<Orders>();

            if (!LayoutControl.IsInDesignMode)
            {
                string connectionString = string.Format(@"Data Source = {0}", LayoutControl.FindFile("Northwind.sdf"));
                northWind = new Northwind(connectionString);
                var emp = northWind.Orders.Take(15).ToList();
                foreach (var o in emp)
                {
                    ordersDetails.Add(o);
                }
            }
            return ordersDetails;
        }
    }
}
