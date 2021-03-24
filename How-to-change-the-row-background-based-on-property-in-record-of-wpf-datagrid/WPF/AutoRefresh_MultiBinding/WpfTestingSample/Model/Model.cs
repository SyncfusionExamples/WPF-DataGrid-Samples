using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace WpfTestingSample
{

    public class BusinessObjects : INotifyPropertyChanged
    {
        private string _CountryCode;

        public string CountryCode
        {
            get { return _CountryCode; }
            set
            {
                _CountryCode = value;
                OnPropertyChanged("CountryCode");
            }
        }

        private int _eage;
        public int EmployeeAge
        {
            get
            {
                return _eage;
            }
            set
            {
                _eage = value;
                OnPropertyChanged("EmployeeAge");
            }
        }

        private string _earea;
        public string EmployeeArea
        {
            get
            {
                return _earea;
            }
            set
            {
                _earea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        private string _egender;
        public string EmployeeGender
        {
            get
            {
                return _egender;
            }
            set
            {
                _egender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

        private int _eExpInMonth;
        public int ExperienceInMonth
        {
            get
            {
                return _eExpInMonth;
            }
            set
            {
                _eExpInMonth = value;
                OnPropertyChanged("ExperienceInMonth");
            }
        }

        private double _esalary;
        public double EmployeeSalary
        {
            get
            {
                return _esalary;
            }
            set
            {
                _esalary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }

        private DateTime _edatetime;
        public DateTime EmployeeDate
        {
            get
            {
                return _edatetime;
            }
            set
            {
                _edatetime = value;
                OnPropertyChanged("EmployeeDate");
            }
        }

        private string empinfo;
        public string EmployeeInfo
        {
            get { return empinfo; }
            set 
            {
                empinfo = value;
                OnPropertyChanged("EmployeeInfo");
            }
        }
        private bool isChecked = false;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
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
