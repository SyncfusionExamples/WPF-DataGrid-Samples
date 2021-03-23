using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int productId;
        private string _productName;
        private double _NoOfOrders;
        private DateTime _orderDate;
        private DateTime _shipDate;
        private string countryName;
        private string shipCity;
        private int _shipid;

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                this.RaisePropertyChanged("ProductId");
            }
        }

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

        public double NoOfOrders
        {
            get
            {
                return _NoOfOrders;
            }
            set
            {
                _NoOfOrders = value;
                RaisePropertyChanged("NoOfOrders");
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
            set
            {
                _orderDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }

        public DateTime ShipDate
        {
            get
            {
                return _shipDate;
            }
            set
            {
                _shipDate = value;
                RaisePropertyChanged("ShipDate");
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                RaisePropertyChanged("CountryName");
            }
        }

        public string ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        public int ShipId
        {
            get
            {
                return _shipid;
            }
            set
            {
                _shipid = value;
                RaisePropertyChanged("ShipId");
            }
        }

        public OrderInfo()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
