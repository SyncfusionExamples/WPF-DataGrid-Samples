using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGrid_CopyPaste
{
    public class Product : INotifyPropertyChanged
    {      
        private int productId;
        private string _productName;
        private double _NoOfOrders;
        private DateTime _orderDate;
        private string countryName;
        private string shipCity;  

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

        public string CountryName
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                RaisePropertyChanged("CountryDescription");
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

        public Product()
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
