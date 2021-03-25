using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rowheight
{
    public class BusinessObjects : INotifyPropertyChanged
    {
        #region private properties

        private string _ename;
        private int _eage;
        private string _earea;
        private string _egender;
        private int _eExpInMonth;
        private double _esalary;

        #endregion

        #region public properties
        public string EmployeeName
        {
            get
            {
                return _ename;
            }
            set
            {
                _ename = value;
                OnPropertyChanged("EmployeeName");
            }
        }


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

        #endregion

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
