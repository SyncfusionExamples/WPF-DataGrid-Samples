using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Employee : INotifyPropertyChanged
    {
        private int _employeeID;
        private string _Name;
        private DateTime _BirthDate;
        private double _SickLeaveHours;
        private string _Gender;
        private decimal _Salary;

        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public DateTime BirthDate
        {
            get { return this._BirthDate; }
            set
            {
                this._BirthDate = value;
                this.RaisePropertyChanged("BirthDate");
            }
        }

        public string Gender
        {
            get { return this._Gender; }
            set
            {
                this._Gender = value;
                this.RaisePropertyChanged("Gender");
            }
        }

        public decimal Salary
        {
            get { return this._Salary; }
            set
            {
                this._Salary = value;
                this.RaisePropertyChanged("Salary");
            }
        }

        public double SickLeaveHours
        {
            get { return this._SickLeaveHours; }
            set
            {
                this._SickLeaveHours = value;
                this.RaisePropertyChanged("SickLeaveHours");
            }
        }
        public Employee()
        { }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
