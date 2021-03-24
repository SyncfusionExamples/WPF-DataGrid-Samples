using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSummary_CellStyle
{
    public class ViewModel : INotifyPropertyChanged
    {

        #region ObservableCollection

        private ObservableCollection<Product> product;
        public ObservableCollection<Product> Products
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged("Products");
            }
        }

        #endregion

        #region ctr

        public ViewModel()
        {
            product = new ObservableCollection<Product>();
            this.GetDetails();
        }

        private void GetDetails()
        {
            Products.Add(new Product("P1", "HardWare", 1, "Jon", "C2", "Ac", 1, "Shiped", "US"));
            Products.Add(new Product("P2", "Software", 2, "Jhon", "C1", "c", 2, "Shiped", "Uk"));
            Products.Add(new Product("P3", "HardWare", 3, "Michel", "C3", "bc", 3, "Shiped", "Us"));
            Products.Add(new Product("P4", "Software", 4, "Rose", "C4", "sc", 5, "Shiped", "Uk"));
            Products.Add(new Product("P5", "HardWare", 5, "Son", "C5", "sc", 3, "Shiped", "Us"));
            Products.Add(new Product("P6", "Software", 4, "tom", "C6", "dbc", 3, "Shiped", "Uk"));
            Products.Add(new Product("P7", "HardWare", -7, "jery", "C7", "fc", 3, "Shiped", "US"));
            Products.Add(new Product("P8", "Software", -8, "Rose", "C8", "vbc", 3, "Shiped", "Uk"));
            Products.Add(new Product("P9", "HardWare", -9, "hhon", "C9", "bbbc", 3, "Shiped", "US"));
            Products.Add(new Product("P10", "Software", -10, "tom", "C10", "bbbc", 3, "Shiped", "Uk"));

        }

        #endregion

        #region NotifyPropertyChanged

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

        #endregion
    }
}
