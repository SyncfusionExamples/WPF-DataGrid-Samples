using SfDataGrid_ComboBoxDemo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_ComboBoxDemo
{
    public class ViewModel : INotifyPropertyChanged
    {       
        private List<OrderInfo> _orderList;
        public List<OrderInfo> OrderList
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
        public List<OrderInfo> Generate()
        {
            _orderList = new List<OrderInfo>();
            _orderList.Add(new OrderInfo() { ProductId = 1001, ProductName = "Alice Mutton", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 2), CountryName = "Argentina", ShipCity= "Graz" });
            _orderList.Add(new OrderInfo() { ProductId = 1002, ProductName = "NuNuCa Nuß-Nougat-Creme", NoOfOrders = 10, OrderDate = new DateTime(2015, 5, 20), CountryName = "Austria", ShipCity= "Cork" });
            _orderList.Add(new OrderInfo() { ProductId = 1003, ProductName = "Boston Crab Meat", NoOfOrders = 100, OrderDate = new DateTime(2015, 5, 3), CountryName = "Belgium",ShipCity= "Helsinki" });
            _orderList.Add(new OrderInfo() { ProductId = 1004, ProductName = "Konbu", NoOfOrders = 50, OrderDate = new DateTime(2015, 5, 13), CountryName = "Brazil", ShipCity= "Århus" });
            _orderList.Add(new OrderInfo() { ProductId = 1005, ProductName = "Boston Crab Meat", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 23), CountryName = "Canada", ShipCity= "Bergamo" });
            _orderList.Add(new OrderInfo() { ProductId = 1006, ProductName = "Raclette Courdavault", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Denmark",ShipCity= "Campinas" });
            _orderList.Add(new OrderInfo() { ProductId = 1007, ProductName = "Wimmers gute Semmelknödel", NoOfOrders = 20, OrderDate = new DateTime(2015, 5, 13), CountryName = "Finland", ShipCity= "Montréal"});
            _orderList.Add(new OrderInfo() { ProductId = 1005, ProductName = "Boston Crab Meat", NoOfOrders = 25, OrderDate = new DateTime(2015, 1, 23), CountryName = "Italy", ShipCity= "Campinas" });
            _orderList.Add(new OrderInfo() { ProductId = 1006, ProductName = "Raclette Courdavault", NoOfOrders = 24, OrderDate = new DateTime(2015, 4, 28), CountryName = "US", ShipCity= "Graz" });
            _orderList.Add(new OrderInfo() { ProductId = 1007, ProductName = "Wimmers gute Semmelknödel", NoOfOrders = 40, OrderDate = new DateTime(2015, 5, 8), CountryName = "UK",ShipCity= "Bergamo"});
            return _orderList;     
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
