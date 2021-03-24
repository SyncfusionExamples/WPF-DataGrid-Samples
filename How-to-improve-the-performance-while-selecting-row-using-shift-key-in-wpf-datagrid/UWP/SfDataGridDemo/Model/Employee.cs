#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        private string _employeeName;
        private int _ContactID;
        private string _Title;
        private DateTime _BirthDate;
        private string _Gender;
        private double _SickLeaveHours;
        private decimal _Salary;

        private int _EmployeeID;

        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }
        public string EmployeeName
        {
            get { return this._employeeName; }
            set
            {
                this._employeeName = value;
                this.RaisePropertyChanged("EmployeeName");
            }
        }
        public string Title
        {
            get { return this._Title; }
            set
            {
                this._Title = value;
                this.RaisePropertyChanged("Title");
            }
        }

        public int ContactID
        {
            get { return this._ContactID; }
            set
            {
                this._ContactID = value;
                this.RaisePropertyChanged("ContactID");
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

        public double SickLeaveHours
        {
            get { return this._SickLeaveHours; }
            set
            {
                this._SickLeaveHours = value;
                this.RaisePropertyChanged("SickLeaveHours");
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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
