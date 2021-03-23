using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class BusinessObject : INotifyPropertyChanged
    {
        private string contactNumber;

        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

        private int _eid;
        public int EmployeeID
        {
            get
            {
                return _eid;
            }
            set
            {
                _eid = value;
                OnPropertyChanged("EmployeeID");
            }
        }

        private string _ename;
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

        private DateTime joiningDate;
        public DateTime JoiningDate
        {
            get
            {
                return joiningDate;
            }
            set
            {
                joiningDate = value;
                OnPropertyChanged("JoiningDate");
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
