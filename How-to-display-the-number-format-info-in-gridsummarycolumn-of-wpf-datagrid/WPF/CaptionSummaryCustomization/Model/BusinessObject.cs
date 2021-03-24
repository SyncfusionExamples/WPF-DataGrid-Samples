using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptionSummaryCustomization
{
    public class BusinessObjects : INotifyPropertyChanged
    {
        #region private properties

        private string _contactNumber;
        private string _empName;
        private string _empArea;
        private string _empGender;
        private int _expInMonth;
        private double _empsalary;
        private DateTime joiningDate;

        #endregion

        #region public properties
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
                OnPropertyChanged("ContactNumber");
            }
        }

      
        public string EmployeeName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
                OnPropertyChanged("EmployeeName");
            }
        }

      
        public string EmployeeArea
        {
            get
            {
                return _empArea;
            }
            set
            {
                _empArea = value;
                OnPropertyChanged("EmployeeArea");
            }
        }

        
        public string EmployeeGender
        {
            get
            {
                return _empGender;
            }
            set
            {
                _empGender = value;
                OnPropertyChanged("EmployeeGender");
            }
        }

       
        public int ExperienceInMonth
        {
            get
            {
                return _expInMonth;
            }
            set
            {
                _expInMonth = value;
                OnPropertyChanged("ExperienceInMonth");
            }
        }

       
        public double EmployeeSalary
        {
            get
            {
                return _empsalary;
            }
            set
            {
                _empsalary = value;
                OnPropertyChanged("EmployeeSalary");
            }
        }

       
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
