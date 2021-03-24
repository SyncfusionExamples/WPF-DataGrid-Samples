using Syncfusion.Windows.Shared;
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
        int productId;
        string _productName;
        double _NoOfOrders;
        DateTime _orderDate;
        string countryName;
        string shipCity;
        int _shipid;

        public int ProductId
        {
            get
            {
                return productId;
            }
            private set
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
        public OrderInfo() { }

        public OrderInfo(int productId, string _productName, string countryName, int _shipid)
        {
            this.ProductId = productId;
            this.ProductName = _productName;
            this.CountryName = countryName;
            this.ShipId = _shipid;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

      
    

