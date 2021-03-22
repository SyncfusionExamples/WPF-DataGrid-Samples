using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MasterDetailsViewDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {

        private int _OrderID;

        private string _CustomerID;

        private System.Nullable<int> _EmployeeID;

        private string _ShipCity;

        private string _ShipCountry;

        private double _Freight;

        private List<OrderDetails> orderDetails;
        private bool _isClosed;

        private DateTime _shippingDate;

        public OrderInfo()
        {

        }

        public List<OrderDetails> OrderDetails
        {
            get { return this.orderDetails; }
            set
            {
                this.orderDetails = value;
                RaisePropertyChanged("OrderDetails");
            }
        }

        public int OrderID
        {
            get { return this._OrderID; }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get { return this._CustomerID; }
            set
            {
                this._CustomerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public DateTime ShippingDate
        {
            get { return _shippingDate; }
            set
            {
                _shippingDate = value;
                RaisePropertyChanged("ShippingDate");
            }
        }

        public System.Nullable<int> EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        public string ShipCity
        {
            get { return this._ShipCity; }
            set
            {
                this._ShipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }

        public string ShipCountry
        {
            get { return this._ShipCountry; }
            set
            {
                this._ShipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        public double Freight
        {
            get { return this._Freight; }
            set
            {
                this._Freight = value;
                RaisePropertyChanged("Freight");
            }
        }

        public bool IsClosed
        {
            get { return this._isClosed; }

            set
            {
                this._isClosed = value;
                this.RaisePropertyChanged("IsClosed");
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
