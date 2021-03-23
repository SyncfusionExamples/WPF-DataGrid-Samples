using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public partial class OrderInfo : NotificationObject
    {

        private int _OrderID;

        private string _CustomerID;

        private string _EmployeeID;

        private string _ShipCity;

        private string _ShipCountry;

        private double _unitPrice;

        private double _Freight;

        private bool _isClosed;

        private string _ShipPostalCode;

        private DateTime _Shipping = DateTime.Now;

        private double _Discount;

        private int _Quantity;

        private double _Expense;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderInfo"/> class.
        /// </summary>
        public OrderInfo()
        {

        }

        /// <summary>
        /// Gets or sets the order ID.
        /// </summary>
        /// <value>The order ID.</value>
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this._OrderID = value;
                this.RaisePropertyChanged("OrderID");
            }
        }

        /// <summary>
        /// Gets or sets the shipping.
        /// </summary>
        /// <value>
        /// The shipping.
        /// </value>
        public DateTime Shipping
        {
            get
            {
                return _Shipping;
            }
            set
            {
                _Shipping = value;
                RaisePropertyChanged("Shipping");
            }
        }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        /// <value>The customer ID.</value>
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
                this.RaisePropertyChanged("CustomerID");
            }
        }

        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                _Quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }

        public double Discount
        {
            get
            {
                return _Discount;
            }
            set
            {
                _Discount = value;
                RaisePropertyChanged("Discount");
            }
        }

        /// <summary>
        /// Gets or sets the employee ID.
        /// </summary>
        /// <value>The employee ID.</value>
        public string EmployeeID
        {
            get
            {
                return this._EmployeeID;
            }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        /// <summary>
        /// Gets or sets the ship city.
        /// </summary>
        /// <value>The ship city.</value>
        public string ShipCity
        {
            get
            {
                return this._ShipCity;
            }
            set
            {
                this._ShipCity = value;
                this.RaisePropertyChanged("ShipCity");
            }
        }

        /// <summary>
        /// Gets or sets the ship country.
        /// </summary>
        /// <value>The ship country.</value>
        public string ShipCountry
        {
            get
            {
                return this._ShipCountry;
            }
            set
            {
                this._ShipCountry = value;
                this.RaisePropertyChanged("ShipCountry");
            }
        }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>The unit price.</value>
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                RaisePropertyChanged("UnitPrice");
            }
        }

        /// <summary>
        /// Gets or sets the freight.
        /// </summary>
        /// <value>The freight.</value>
        public double Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
                this.RaisePropertyChanged("Freight");
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is closed.
        /// </summary>
        /// <value><c>true</c> if this instance is closed; otherwise, <c>false</c>.</value>
        public bool IsClosed
        {
            get
            {
                return this._isClosed;
            }

            set
            {
                this._isClosed = value;
                this.RaisePropertyChanged("IsClosed");
            }
        }


        public string ShipPostalCode
        {
            get
            {
                return this._ShipPostalCode;
            }
            set
            {
                this._ShipPostalCode = value;
                this.RaisePropertyChanged("ShipPostalCode");
            }
        }

        public double Expense
        {
            get
            {
                return this._Expense;
            }
            set
            {
                this._Expense = value;
                this.RaisePropertyChanged("Expense");
            }
        }
    }

    public class ProductInfo : NotificationObject
    {
        private int _ProductID;

        private string _ProductModel;

        private int _UserRating;

        private string _Product;

        private bool _Availability;

        private double _Price;

        private int _shippingDays;

        private string _ProductType;


        public int ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this._ProductID = value;
                this.RaisePropertyChanged("ProductID");
            }
        }

        public string ProductModel
        {
            get
            {
                return this._ProductModel;
            }
            set
            {
                this._ProductModel = value;
                this.RaisePropertyChanged("ProductModel");
            }
        }

        public int UserRating
        {
            get
            {
                return this._UserRating;
            }
            set
            {
                this._UserRating = value;
                this.RaisePropertyChanged("UserRating");
            }
        }

        public bool Availability
        {
            get
            {
                return this._Availability;
            }
            set
            {
                this._Availability = value;
                this.RaisePropertyChanged("Availability");
            }
        }

        public double Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this._Price = value;
                this.RaisePropertyChanged("Price");
            }
        }

        public int ShippingDays
        {
            get
            {
                return this._shippingDays;
            }
            set
            {
                this._shippingDays = value;
                this.RaisePropertyChanged("ShippingDays");
            }
        }

        public string ProductType
        {
            get
            {
                return this._ProductType;
            }
            set
            {
                this._ProductType = value;
                this.RaisePropertyChanged("ProductType");
            }
        }

        public string Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this._Product = value;
                this.RaisePropertyChanged("Product");
            }
        }
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
