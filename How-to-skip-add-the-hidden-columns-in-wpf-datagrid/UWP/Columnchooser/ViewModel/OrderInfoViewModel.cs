using Syncfusion.UI.Xaml.Utils;
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
    internal delegate void Toggled();
    public class OrderInfoViewModel : NotificationObject, IDisposable
    {

        public OrderInfoViewModel()
        {
            OrdersListDetails = new OrderInfoRepository().GetListOrdersDetails(2000);
            _comboBoxItemsSource = styleName.ToList();
        }

        internal Toggled toggled;

        private ICommand togglebuttonToggled;

        public ICommand TogglebuttonToggled
        {
            get { return new DelegateCommand(ToggledEvent, args => true); }
            set { togglebuttonToggled = value; RaisePropertyChanged("TogglebuttonToggled"); }
        }

        private void ToggledEvent(object pram)
        {
            if (pram != null)
            {
                this.ShowColumnChooser = (bool)pram;
                toggled();
            }
        }

        private bool showColumnChooser = false;

        public bool ShowColumnChooser
        {
            get
            {
                return showColumnChooser;
            }
            set
            {
                showColumnChooser = value;
                RaisePropertyChanged("ShowColumnChooser");
            }
        }



        private List<OrderInfo> _ordersListDetails;

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public List<OrderInfo> OrdersListDetails
        {
            get { return _ordersListDetails; }
            set { _ordersListDetails = value; }
        }

        private ObservableCollection<OrderInfo> _ordersDetails;

        /// <summary>
        /// Gets or sets the orders details.
        /// </summary>
        /// <value>The orders details.</value>
        public ObservableCollection<OrderInfo> OrdersDetails
        {
            get { return _ordersDetails; }
            set { _ordersDetails = value; }
        }

        private List<string> _comboBoxItemsSource;

        public List<string> ComboBoxItemsSource
        {
            get { return _comboBoxItemsSource; }
            set { _comboBoxItemsSource = value; }
        }

        string[] styleName = new string[]
        {
            "Windows7",
            "Metro",
            "Blend",
            "Office2007Black",
            "Office2007Blue",
            "Office2007Silver",
            "Office2010Black",
            "Office2010Blue",
            "Office2010Silver"
        };

        public void Dispose()
        {
            if (OrdersDetails != null)
            {
                this.OrdersDetails.Clear();
            }
            if (this.OrdersListDetails != null)
            {
                this.OrdersListDetails.Clear();
            }
        }
    }
}
