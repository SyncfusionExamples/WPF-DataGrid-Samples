using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGridFiltering
{
    public class Product : INotifyPropertyChanged
    {

        #region private properties

        private string productId;
        private string productName;
        private double? salesID;
        private string customerName;
        private string customerId;
        private int? Id;
        private string shipmentdetails;
        private string shipmentplace;

        #endregion

        #region public properties
        public string ProductId
        {
            get { return productId; }
            set { productId = value; OnPropertyChanged("ProductId"); }
        }
      

        public string ProductName
        {
            get { return productName; }
            set { productName = value; OnPropertyChanged("ProductName"); }
        }
      

        public double? SalesID
        {
            get { return salesID; }
            set { salesID = value; OnPropertyChanged("SalesID"); }
        }
       

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; OnPropertyChanged("CustomerName"); }
        }

       

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; OnPropertyChanged("CustomerId"); }
        }
        private string customerBranch;

        public string CustomerBranch
        {
            get { return customerBranch; }
            set { customerBranch = value; OnPropertyChanged("CustomerBranch"); }
        }
        
        public int? ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }
        
        public string ShipmentDetails
        {
            get { return shipmentdetails; }
            set { shipmentdetails = value; OnPropertyChanged("ShipmentDetails"); }
        }
        
        public string ShipmentPlace
        {
            get { return shipmentplace; }
            set { shipmentplace = value; OnPropertyChanged("ShipmentPlace"); }
        }
        public Product(string productId, string productName, double? salesID, string customerName, string customerId, string customerBranch, int? Id, string shipmentdetails, string shipmentplace)
        {
            this.productId = productId;
            this.productName = productName;
            this.salesID = salesID;
            this.customerName = customerName;
            this.customerId = customerId;
            this.customerBranch = customerBranch;
            this.Id = Id;
            this.shipmentdetails = shipmentdetails;
            this.shipmentplace = shipmentplace;

        }

        #endregion

        #region NotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        #endregion
    }
}
