using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo:INotifyPropertyChanged
    {
      private int orderID;
      private string customerId;
      private string country;
      private string customerName;
      private string shippingCity;
      private bool isSelected;

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
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                RaiseNotifyChanged("IsSelected");
            }
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
        customerId, string shipCity, bool isSelected)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
           this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.IsSelected = isSelected;
    
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
