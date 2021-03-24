using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnChooserDemo.Model
{
    public class OrderInfo : NotificationObject
    {
        private int orderID;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;

        private bool _isChecked;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is checked.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is checked; otherwise, <c>false</c>.
        /// </value>
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                RaisePropertyChanged("IsChecked");
            }
        }
        public string _name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }



        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; RaiseNotifyChanged("OrderID"); }
        }
        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; RaiseNotifyChanged("CustomerID"); }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; RaiseNotifyChanged("CustomerName"); }
        }
        public string Country
        {
            get { return country; }
            set { country = value; RaiseNotifyChanged("Country"); }
        }
        public string ShipCity
        {
            get { return shippingCity; }
            set { shippingCity = value; RaiseNotifyChanged("ShipCity"); }
        }

        public OrderInfo(int orderId, string customerName, string country, string
        customerId, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
        }
        public OrderInfo()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseNotifyChanged(String prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
