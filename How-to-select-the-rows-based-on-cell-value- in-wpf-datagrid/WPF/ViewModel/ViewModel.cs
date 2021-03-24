using SfDataGridDemo;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> orderCollection;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get
            {
                return orderCollection;
            }
            set
            {
                orderCollection = value;
            }
        }

        public ViewModel()
        {
            orderCollection = new ObservableCollection<OrderInfo>();
            OrderInfoCollection = GenerateOrders1();
        }

        public ObservableCollection<OrderInfo> GenerateOrders1()
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();
            orders.Add(new OrderInfo(1001, "Bulk", "Beverton", "ALFKI", "US"));
            orders.Add(new OrderInfo(1002, "Oliver", "Oregon", "ANATR", "us"));
            orders.Add(new OrderInfo(1003, "Brendon", "Johanesberg", "ANTON", "China"));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "YHGTR", "UK"));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US"));
            orders.Add(new OrderInfo(1007, "Friedo", "Britain", "YTREW", "US"));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Mumbai"));
            orders.Add(new OrderInfo(1009, "Sirert", "Bulk", "BGFDE", "US"));
            orders.Add(new OrderInfo(1010, "Rakesh", "hertion", "BOTTM", "Britain"));
            orders.Add(new OrderInfo(1011, "George", "Oregon", "TGVFD", "US"));
            orders.Add(new OrderInfo(1004, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "Bulk", "UK"));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China"));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US"));
            orders.Add(new OrderInfo(1007, "Friedo", "James", "YTREW", "US"));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Bulk"));
            return orders;
        }
    }
}

