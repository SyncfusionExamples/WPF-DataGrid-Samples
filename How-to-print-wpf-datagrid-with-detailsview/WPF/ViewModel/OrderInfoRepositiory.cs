
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SfDataGridDemo
{
    public class OrderInfoRepositiory : INotifyPropertyChanged
    {
        ObservableCollection<OrderInfo> orderCollection;        
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderCollection; }
            set { orderCollection = value; }
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
        
            orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", getorder(1001)));
            orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F.", getorder(1002)));
            orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "México D.F.", getorder(1003)));
            orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", getorder(1004)));
            orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Luleå", getorder(1005)));
            orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", getorder(1006)));
            orders.Add(new OrderInfo(1007, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", getorder(1007)));
            orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", getorder(1008)));
            orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", getorder(1009)));
            orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", getorder(1010)));
            orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", getorder(1006)));
            orders.Add(new OrderInfo(1007, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", getorder(1007)));
            orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", getorder(1008)));
            orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", getorder(1009)));
            orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", getorder(1010)));
            orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim", getorder(1006)));
            orders.Add(new OrderInfo(1007, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", getorder(1007)));
            orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid", getorder(1008)));
            orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille", getorder(1009)));
            orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", getorder(1010)));

            return orders;
        }
        List<ProductInfo> prod = new List<ProductInfo>();
        public void GenerateProducts()
        {
            prod.Add(new ProductInfo() { OrderID = 1001, ProductName = "Laptop" });
            prod.Add(new ProductInfo() { OrderID = 1001, ProductName = "Mobile" });
            prod.Add(new ProductInfo() { OrderID = 1001, ProductName = "HeadSet" });
            prod.Add(new ProductInfo() { OrderID = 1002, ProductName = "FootWear" });
            prod.Add(new ProductInfo() { OrderID = 1002, ProductName = "Bags" });
            prod.Add(new ProductInfo() { OrderID = 1002, ProductName = "DataCard" });
            prod.Add(new ProductInfo() { OrderID = 1003, ProductName = "TV" });
            prod.Add(new ProductInfo() { OrderID = 1003, ProductName = "Fridge" });
            prod.Add(new ProductInfo() { OrderID = 1004, ProductName = "Watch" });
            prod.Add(new ProductInfo() { OrderID = 1004, ProductName = "Bike" });
            prod.Add(new ProductInfo() { OrderID = 1005, ProductName = "Car" });
            prod.Add(new ProductInfo() { OrderID = 1005, ProductName = "CPU" });
            prod.Add(new ProductInfo() { OrderID = 1005, ProductName = "KeyBoard" });
            prod.Add(new ProductInfo() { OrderID = 1006, ProductName = "Books" });
            prod.Add(new ProductInfo() { OrderID = 1006, ProductName = "PenDrive" });
            prod.Add(new ProductInfo() { OrderID = 1007, ProductName = "Camera" });
            prod.Add(new ProductInfo() { OrderID = 1008, ProductName = "MP3" });
            prod.Add(new ProductInfo() { OrderID = 1008, ProductName = "DeskTop" });
            prod.Add(new ProductInfo() { OrderID = 1008, ProductName = "MemoryCard" });
        }
        public List<ProductInfo> getorder(int i)
        {
            List<ProductInfo> product = new List<ProductInfo>();
            foreach (var or in prod)
                if (or.OrderID == i)
                    product.Add(or);
            return product;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
