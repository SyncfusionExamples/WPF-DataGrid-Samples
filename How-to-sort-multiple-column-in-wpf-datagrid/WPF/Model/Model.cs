using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : NotificationObject
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
        /// Gets or sets the Employee ID details.
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
        /// Gets or sets the Employee Name details.
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
        /// Gets or sets the Employee Designation details.
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
        /// Gets or sets the Employee Age details.
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
        /// Gets or sets the Employee Address details.
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
        /// Gets or sets the Employee Gender details.
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
        /// Gets or sets the Employee Experience details in months.
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
        /// Gets or sets the Employee salary details
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
    }
}
