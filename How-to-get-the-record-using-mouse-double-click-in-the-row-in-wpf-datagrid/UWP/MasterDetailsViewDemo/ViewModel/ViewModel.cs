
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsViewDemo
{
   public class ViewModel: INotifyPropertyChanged
    {
        public ViewModel()
        {
            OrderInfoRepository order = new OrderInfoRepository();
            OrdersDetails = order.GetOrdersDetails(100);
        }

        public List<OrderInfo> _ordersDetails;

        public List<OrderInfo> OrdersDetails
        {
            get { return _ordersDetails; }
            set { _ordersDetails = value; }
        }

        public OrderInfo _selectedItem;

        public OrderInfo SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
    }
}
