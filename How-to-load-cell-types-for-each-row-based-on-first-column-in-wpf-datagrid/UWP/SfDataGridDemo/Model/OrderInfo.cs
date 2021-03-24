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
//using Syncfusion.UI.Xaml.Grid.Cells;
using System.Windows;
using System.Reflection;


namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private double _orderId;
        private string _productName;
        private bool isClosed;

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        public double OrderID
        {
            get
            {
                return _orderId;
            }
            set
            {
                _orderId = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private double productID;

        public double ProductID
        {
            get { return productID; }
            set
            {
                productID = value;
                RaisePropertyChanged("ProductID");
            } 
        }

        


        public bool IsClosed
        {
            get 
            {
                return isClosed; 
            }
            set 
            {
                isClosed = value;
                RaisePropertyChanged("IsClosed");
            }
        }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>The customer ID.</value>

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>The name of the product.</value>
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
             
                RaisePropertyChanged("ProductName");
            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
            }
        }
        private string city1;
        public string City1
        {
            get { return city1; }
            set
            {
                city1 = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

}