using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsView_NestedLevel
{
    public class ProductInfo : INotifyPropertyChanged
    {
        private int orderId;
        private string productName;
        private DateTime date;

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                RaisePropertyChanged("ProductName");
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                RaisePropertyChanged("Date");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
