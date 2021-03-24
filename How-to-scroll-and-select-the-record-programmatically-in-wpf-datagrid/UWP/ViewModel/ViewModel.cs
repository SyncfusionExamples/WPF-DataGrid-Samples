using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        EmployeeDetails emp = new EmployeeDetails();

        #region Constructor

        public ViewModel()
        {
            this.ItemSource = emp;
            SelectedItem = this.ItemSource[22];
        }

        #endregion

        private object _selectedItem;
        public object SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> ItemSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
                OnPropertyChanged("ItemSource");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
