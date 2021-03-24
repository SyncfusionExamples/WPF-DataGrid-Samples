using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> _orderList;
        public ObservableCollection<OrderInfo> OrderList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
                RaisePropertyChanged("OrderList");
            }
        }
        public ObservableCollection<string> _shipcities;
        public ObservableCollection<string> Shipcities
        {
            get
            {
                return _shipcities;
            }
            set
            {
                _shipcities = value;
            }
        }
        public ViewModel()
        {
            this.Generate();
        }

        public void Generate()
        {
            _orderList = new ObservableCollection<OrderInfo>();
            _orderList.Add(new OrderInfo() { ProductId = 1001, ProductName = "Alice Mutton", NoOfOrders = 10, ShipDate = new DateTime(1991, 9, 8), OrderDate = new DateTime(2001, 5, 2), CountryName = "Argentina", ShipCity = "Graz" });
            _orderList.Add(new OrderInfo() { ProductId = 1002, ProductName = "NuNuCa Nuß-Nougat-Creme", NoOfOrders = 10, ShipDate = new DateTime(2015, 11, 8), OrderDate = new DateTime(2015, 5, 20), CountryName = "Austria", ShipCity = "Cork" });
            _orderList.Add(new OrderInfo() { ProductId = 1003, ProductName = "Boston Crab Meat", NoOfOrders = 100, ShipDate = new DateTime(1991, 9, 8), OrderDate = new DateTime(1999, 5, 3), CountryName = "Belgium", ShipCity = "Helsinki" });
            _orderList.Add(new OrderInfo() { ProductId = 1004, ProductName = "Konbu", NoOfOrders = 50, ShipDate = new DateTime(2015, 11, 8), OrderDate = new DateTime(2015, 5, 13), CountryName = "Brazil", ShipCity = "Århus" });
            _orderList.Add(new OrderInfo() { ProductId = 1005, ProductName = "Boston Crab Meat", NoOfOrders = 20, ShipDate = new DateTime(1991, 9, 8), OrderDate = new DateTime(2016, 6, 23), CountryName = "Canada", ShipCity = "Bergamo" });
            _orderList.Add(new OrderInfo() { ProductId = 1006, ProductName = "Raclette Courdavault", NoOfOrders = 20, ShipDate = new DateTime(1991, 9, 17), OrderDate = new DateTime(2015, 7, 13), CountryName = "Denmark", ShipCity = "Campinas" });
            _orderList.Add(new OrderInfo() { ProductId = 1007, ProductName = "Wimmers gute Semmelknödel", NoOfOrders = 20, ShipDate = new DateTime(2015, 11, 8), OrderDate = new DateTime(2015, 5, 13), CountryName = "Island", ShipCity = "Montréal" });
            _orderList.Add(new OrderInfo() { ProductId = 1008, ProductName = "Boston Crab Meat", NoOfOrders = 25, ShipDate = new DateTime(2015, 11, 8), OrderDate = new DateTime(2015, 5, 23), CountryName = "Italy", ShipCity = "Campinas" });
            _orderList.Add(new OrderInfo() { ProductId = 1009, ProductName = "Raclette Courdavault", NoOfOrders = 24, ShipDate = new DateTime(2015, 7, 01), OrderDate = new DateTime(2015, 5, 28), CountryName = "US", ShipCity = "Graz" });
            _orderList.Add(new OrderInfo() { ProductId = 10010, ProductName = "Wimmers gute Semmelknödel", NoOfOrders = 40, ShipDate = new DateTime(2015, 11, 8), OrderDate = new DateTime(2015, 5, 8), CountryName = "Indonesia", ShipCity = "Bergamo" });
            _orderList.Add(new OrderInfo() { ProductId = 10011, ProductName = "Raclette Courdavault", NoOfOrders = 24, ShipDate = new DateTime(2015, 5, 01), OrderDate = new DateTime(2015, 5, 28), CountryName = "UK", ShipCity = "Graz" });
            _orderList.Add(new OrderInfo() { ProductId = 10012, ProductName = "Raclette Courdavault", NoOfOrders = 24, ShipDate = new DateTime(2015, 5, 01), OrderDate = new DateTime(2015, 5, 28), CountryName = "UK", ShipCity = "Graz" });
            _shipcities = new ObservableCollection<string>();
            _shipcities.Add("Bergamo");
            _shipcities.Add("Graz");
            _shipcities.Add("Campinas");
            _shipcities.Add("Helsinki");
            _shipcities.Add("Århus");
            _shipcities.Add("Cork");
            _shipcities.Add("Montréal");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
