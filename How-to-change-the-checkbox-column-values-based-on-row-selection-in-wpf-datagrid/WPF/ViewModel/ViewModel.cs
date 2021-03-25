using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
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

        private bool? isselectAll = false;
        public bool? IsSelectAll
        {
            get
            {
                return isselectAll;
            }
            set
            {
                isselectAll = value;
                OnPropertyChanged("IsSelectAll");
            }
        }
        
        public ObservableCollection<OrderInfo> GenerateOrders1()
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();
            orders.Add(new OrderInfo(1001, "James", "Beverton", "ALFKI", "US", false));
            orders.Add(new OrderInfo(1002, "Oliver", "Oregon", "ANATR", "us", false));
            orders.Add(new OrderInfo(1003, "Brendon", "Johanesberg", "ANTON", "China", false));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "YHGTR", "UK", false));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China", false));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US", false));
            orders.Add(new OrderInfo(1007, "Friedo", "Britain", "YTREW", "US", false));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Mumbai", false));
            orders.Add(new OrderInfo(1009, "Sirert", "Chimer", "BGFDE", "US", false));
            orders.Add(new OrderInfo(1010, "Rakesh", "hertion", "BOTTM", "Britain", false));
            orders.Add(new OrderInfo(1011, "George", "Oregon", "TGVFD", "US", false));
            orders.Add(new OrderInfo(1004, "Charles", "Spain", "BERGS", "China", false));
            orders.Add(new OrderInfo(1004, "John", "Chicago", "YHGTR", "UK", false));
            orders.Add(new OrderInfo(1005, "Charles", "Spain", "BERGS", "China", false));
            orders.Add(new OrderInfo(1006, "Dintin", "Britain", "TGVFD", "US", false));
            orders.Add(new OrderInfo(1007, "Friedo", "Britain", "YTREW", "US", false));
            orders.Add(new OrderInfo(1008, "John", "Oregon", "MNBGY", "Mumbai", false));
            return orders;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }

}

