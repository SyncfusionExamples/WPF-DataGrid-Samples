using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsView_NestedLevel
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;
        private DateTime date;
        private ObservableCollection<ProductInfo> productDetails;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                RaisePropertyChanged("Date");
            }
        }

        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                RaisePropertyChanged("CustomerName");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                RaisePropertyChanged("Country");
            }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set
            {
                shippingCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }

        public ObservableCollection<ProductInfo> ProductDetails
        {
            get { return productDetails; }
            set
            {
                productDetails = value;
                RaisePropertyChanged("ProductDetails");
            }
        }

        public OrderInfo(int orderId, string customerName, string country, string
            customerId, string shipCity, DateTime _date, ObservableCollection<ProductInfo> productdetails)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.Date = _date;
            this.ProductDetails = productdetails;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
