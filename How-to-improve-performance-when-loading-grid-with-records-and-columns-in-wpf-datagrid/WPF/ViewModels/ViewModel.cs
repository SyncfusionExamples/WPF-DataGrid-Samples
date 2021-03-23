using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Syncfusion.Windows.Shared;
using System.ComponentModel;

namespace SfDataGridDemo_sample
{
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            _orderCollection = new ObservableCollection<ColumnModel>();
            OrderCollection = GetOrders();
        }

        private ObservableCollection<ColumnModel> _orderCollection;

        /// <summary>
        /// Gets or sets the order collection.
        /// </summary>
        /// <value>The order collection.</value>
        public ObservableCollection<ColumnModel> OrderCollection
        {
            get { return _orderCollection; }
            set
            {
                _orderCollection = value;
                RaisePropertyChanged("GDCSource");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
        }

        /// <summary>
        /// Gets the orders.
        /// </summary>
        private ObservableCollection<ColumnModel> GetOrders()
        {
            var details = new ObservableCollection<ColumnModel>();
            for (int i = 0; i <= 12000; i++)
            {
                details.Add(new ColumnModel
                    {
                        column1 = i,
                        column2 = i,
                        column3 = "sampletxt" +i,
                        column4 = "syncText" +i,
                        column5 = "text" +i
                    });
            }
            return details;
        }
    }
}
