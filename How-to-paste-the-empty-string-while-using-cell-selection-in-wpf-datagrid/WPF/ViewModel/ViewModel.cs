using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGrid_CopyPaste
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
                RaisePropertyChanged("OrderList");
            }
        }
   
        public ViewModel()
        {
            _products = new ObservableCollection<Product>();
            _products.Add(new Product() { ProductId = 1001, ProductName = "Alice Mutton", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 2), CountryName = "Argentina", ShipCity = "Buenos Aires" });
            _products.Add(new Product() { ProductId = 1002, ProductName = "NuNuCa Nuß-Nougat-Creme", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 20), CountryName = "Austria", ShipCity = "Graz" });
            _products.Add(new Product() { ProductId = 1003, ProductName = "Boston Crab Meat", NoOfOrders = 100, OrderDate = new DateTime(2015, 5, 3), CountryName = "Belgium", ShipCity = "Bruxelles" });
            _products.Add(new Product() { ProductId = 1004, ProductName = "Konbu", NoOfOrders = 50, OrderDate = new DateTime(2015, 5, 13), CountryName = "Brazil", ShipCity = "Campinas" });
            _products.Add(new Product() { ProductId = 1005, ProductName = "Boston Crab Meat", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 23), CountryName = "Canada", ShipCity = "Montréal" });
            _products.Add(new Product() { ProductId = 1006, ProductName = "Raclette Courdavault", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Denmark", ShipCity = "Århus" });
            _products.Add(new Product() { ProductId = 1007, ProductName = "Wimmers gute Semmelknödel", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Finland", ShipCity = "Helsinki" });
            _products.Add(new Product() { ProductId = 1008, ProductName = "Gorgonzola Telino", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "France", ShipCity = "Lille" });
            _products.Add(new Product() { ProductId = 1009, ProductName = "Fløtemysost", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Germany", ShipCity = "Aachen" });
            _products.Add(new Product() { ProductId = 1010, ProductName = "Chartreuse verte", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Italy", ShipCity = "Bergamo" });
            _products.Add(new Product() { ProductId = 1011, ProductName = "Thüringer Rostbratwurst", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Ireland", ShipCity = "Cork" });
            _products.Add(new Product() { ProductId = 1012, ProductName = "Vegie-spread", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Mexico", ShipCity = "México D.F." });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }   
    }
}


