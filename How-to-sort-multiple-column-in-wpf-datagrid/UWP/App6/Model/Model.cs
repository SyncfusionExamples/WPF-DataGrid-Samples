using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public class Model : INotifyPropertyChanged
    {
        #region Private Fields
        private int _eid;
        private string _ename;
        private string _edesignation;
        private int _eage;
        private string _earea;
        private string _egender;
        private int _eExpInMonth;
        private double _esalary;
        #endregion
        #region Public Property
        /// <summary>
        /// Gets or Sets the Employee Id Details.
        /// </summary>
        public int EmployeeId
        {
            get
            {
                return _eid;
            }
            set
            {
                _eid = value;
                this.RaisePropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        /// Gets or Sets the Employee Name.
        /// </summary>
        public string EmployeeName
        {
            get
            {
                return _ename;
            }
            set
            {
                _ename = value;
                this.RaisePropertyChanged("EmployeeName");
            }
        }

        /// <summary>
        /// Gets or Sets the Designation Details of the Employee.
        /// </summary>
        public string EmployeeDesignation
        {
            get
            {
                return _edesignation;
            }
            set
            {
                _edesignation = value;
                this.RaisePropertyChanged("EmployeeDesignation");
            }
        }
        /// <summary>
        /// Gets or Setts the Age Detail of the Employee.
        /// </summary>

        public int EmployeeAge
        {
            get
            {
                return _eage;
            }
            set
            {
                _eage = value;
                this.RaisePropertyChanged("EmployeeAge");
            }
        }

        /// <summary>
        /// Gets or Sets the Area Details of the Employee.
        /// </summary>
        public string EmployeeArea
        {
            get
            {
                return _earea;
            }
            set
            {
                _earea = value;
                this.RaisePropertyChanged("EmployeeArea");
            }
        }

        /// <summary>
        /// Gets or Sets The Gender Detail of the Employee.
        /// </summary>
        public string EmployeeGender
        {
            get
            {
                return _egender;
            }
            set
            {
                _egender = value;
                this.RaisePropertyChanged("EmployeeGender");
            }
        }

        /// <summary>
        /// Gets or Sets the Experience Details of the Employee in  Months.
        /// </summary>
        public int ExperienceInMonth
        {
            get
            {
                return _eExpInMonth;
            }
            set
            {
                _eExpInMonth = value;
                this.RaisePropertyChanged("ExperienceInMonth");
            }
        }

        /// <summary>
        /// Gets or Sets the Employee Salary Details.
        /// </summary>
        public double EmployeeSalary
        {
            get
            {
                return _esalary;
            }
            set
            {
                _esalary = value;
                this.RaisePropertyChanged("EmployeeSalary");
            }
        }
        #endregion
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
