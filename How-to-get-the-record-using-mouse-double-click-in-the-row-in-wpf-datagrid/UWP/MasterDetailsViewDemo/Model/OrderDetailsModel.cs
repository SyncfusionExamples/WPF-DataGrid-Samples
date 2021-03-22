using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsViewDemo
{
    public class OrderDetails : INotifyPropertyChanged
    {
        private System.Nullable<int> _OrderID;

        public System.Nullable<int> OrderID
        {
            get { return this._OrderID; }
            set
            {
                this._OrderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        private int _ProductID;

        public int ProductID
        {
            get { return this._ProductID; }
            set
            {
                this._ProductID = value;
                RaisePropertyChanged("ProductID");
            }
        }

        private decimal _UnitPrice;

        public decimal UnitPrice
        {
            get { return this._UnitPrice; }
            set
            {
                this._UnitPrice = value;
                RaisePropertyChanged("UnitPrice");
            }
        }

        private Int16 _Quantity;

        public Int16 Quantity
        {
            get { return this._Quantity; }
            set
            {
                this._Quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        private double _Discount;

        public double Discount
        {
            get { return this._Discount; }
            set
            {
                this._Discount = value;
                RaisePropertyChanged("Discount");
            }
        }

        private string _customerID;

        public string CustomerID
        {
            get { return _customerID; }
            set
            {
                _customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set
            {
                _orderDate = value;
                RaisePropertyChanged("OrderDate");
            }
        }

        public OrderDetails(int ord, int prod, decimal unit, Int16 quan, double disc, string cusid, DateTime ordDt)
        {
            this._Discount = disc;
            this._OrderID = ord;
            this._ProductID = prod;
            this._Quantity = quan;
            this._UnitPrice = unit;
            this._customerID = cusid;
            this._orderDate = ordDt;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
