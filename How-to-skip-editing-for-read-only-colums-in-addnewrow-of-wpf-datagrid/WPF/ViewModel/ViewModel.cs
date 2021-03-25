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
        public ViewModel()
        {
            this.Generate();

        }

        public void Generate()
        {
            _orderList = new ObservableCollection<OrderInfo>();
            _orderList.Add(new OrderInfo(1001, "Raclette", "Italy", 112));
            _orderList.Add(new OrderInfo(1002, "Alice Mutton", "UK", 115));
            _orderList.Add(new OrderInfo(1003, "Boston Crab Meat", "Argentina", 118));
            _orderList.Add(new OrderInfo(1004, "Alice Mutton", "US", 114));
            _orderList.Add(new OrderInfo(1005, "Boston Crab Meat", "Argentina", 119));
            _orderList.Add(new OrderInfo(1006, "Konbu", "Argentina", 117));
            _orderList.Add(new OrderInfo(1007, "Alice Mutton", "Brazil", 113));
            _orderList.Add(new OrderInfo(1008, "Boston Crab Meat", "Italy", 112));
            _orderList.Add(new OrderInfo(1001, "Raclette Courdavault", "Belgium", 114));
            _orderList.Add(new OrderInfo(1001, "Wimmers gute Semmelknödel", "Argentina", 111));

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
            
        
     

