using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsView_NestedLevel
{
    public class OrderInfoRepositiory : INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> orderCollection;
        private object _selectedFirstGridItem;
        private ObservableCollection<object> firstNestedGridSelectedItems;
        private object firstNestedCurrentDetails;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderCollection; }
            set
            {
                orderCollection = value;
                RaisePropertyChanged("OrderInfoCollection");
            }
        }
        public object SelectedFirstNestedGridOrderDetails
        {
            get
            {
                return this._selectedFirstGridItem;
            }
            set
            {
                this._selectedFirstGridItem = value;
                this.RaisePropertyChanged("SelectedFirstNestedGridOrderDetails");
            }
        }
        public object FirstNestedCurrentDetails
        {
            get
            {
                return this.firstNestedCurrentDetails;
            }
            set
            {
                this.firstNestedCurrentDetails = value;
                RaisePropertyChanged("FirstNestedCurrentDetails");
            }
        }
        public ObservableCollection<object> FirstNestedGridSelectedItems
        {
            get
            {
                return this.firstNestedGridSelectedItems;
            }
            set
            {
                this.firstNestedGridSelectedItems = value;
                RaisePropertyChanged("FirstNestedGridSelectedItems");
            }
        }


        public OrderInfoRepositiory()
        {
            orderCollection = new ObservableCollection<OrderInfo>();
            this.GenerateProducts();
            OrderInfoCollection = GenerateOrders();
        }

        public ObservableCollection<OrderInfo> GenerateOrders()
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();

            orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", DateTime.Now, getorder(1001)));
            orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F.", DateTime.Now, getorder(1002)));
            orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "México D.F.", DateTime.Now, getorder(1003)));
            orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", DateTime.Now, getorder(1004)));
            orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Luleå", DateTime.Now, getorder(1005)));
            orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", DateTime.Now, getorder(1006)));
            orders.Add(new OrderInfo(1007, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", DateTime.Now, getorder(1007)));
            orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", DateTime.Now, getorder(1008)));
            orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", DateTime.Now, getorder(1009)));
            orders.Add(new OrderInfo(1010, "Maria Anders", "Germany", "ALFKI", "Berlin", DateTime.Now, getorder(1010)));
            orders.Add(new OrderInfo(1011, "Ana Trujilo", "Mexico", "ANATR", "México D.F.", DateTime.Now, getorder(1011)));
            orders.Add(new OrderInfo(1012, "Antonio Moreno", "Mexico", "ANTON", "México D.F.", DateTime.Now, getorder(1012)));
            orders.Add(new OrderInfo(1013, "Thomas Hardy", "UK", "AROUT", "London", DateTime.Now, getorder(1013)));
            orders.Add(new OrderInfo(1014, "Christina Berglund", "Sweden", "BERGS", "Luleå", DateTime.Now, getorder(1014)));
            orders.Add(new OrderInfo(1015, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", DateTime.Now, getorder(1015)));            
            return orders;
        }

        private ObservableCollection<ProductInfo> prod = new ObservableCollection<ProductInfo>();

        public void GenerateProducts()
        {
            prod.Add(new ProductInfo() { OrderID = 1001, ProductName = "Bike1", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1002, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1003, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1004, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1005, ProductName = "Bike1", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1006, ProductName = "Bike3", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1007, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1008, ProductName = "Bike1", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1009, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1010, ProductName = "Bike2", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1011, ProductName = "Bike3", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1012, ProductName = "Bike4", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1013, ProductName = "Bike5", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1014, ProductName = "Bike1", Date = DateTime.Now });
            prod.Add(new ProductInfo() { OrderID = 1015, ProductName = "Bike2", Date = DateTime.Now });            
        }

        public ObservableCollection<ProductInfo> getorder(int i)
        {
            ObservableCollection<ProductInfo> product = new ObservableCollection<ProductInfo>();
            foreach (var or in prod)
                if (or.OrderID == i || or.OrderID == i + 1 || or.OrderID == i - 1)
                    product.Add(or);
            return product;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
