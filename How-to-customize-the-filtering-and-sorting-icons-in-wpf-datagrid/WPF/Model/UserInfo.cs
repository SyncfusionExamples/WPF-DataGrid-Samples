using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomizingGridHeaderCellIcon
{
    public class UserInfo : INotifyPropertyChanged
    {
        #region Fields
        private int userId;
        private string name;
        private DateTime dateofBirth;
        private string contactNo;
        private string city;
        private int salary;
        private bool _boolTest;
        #endregion

        #region Properties

        public int UserId
        {
            get { return userId; }
            set { userId = value; OnPropertyChanged("UserId"); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; OnPropertyChanged("DateofBirth"); }
        }        
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; OnPropertyChanged("ContactNo"); }
        }

        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("City"); }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }
        public bool BoolTest
        {
            get { return _boolTest; }
            set { _boolTest = value; OnPropertyChanged("BoolTest"); }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
