using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : INotifyPropertyChanged
    {
        private int employeeID;
        private string employeename;
        private int employeeage;
        private double employeesalary;

        public int EmployeeID 
        {
            get
            {
                return this.employeeID;
            }
            set
            {
                this.employeeID = value;
                RaisePropertyChanged("EmployeeID");              
            }
        }
        public string EmployeeName
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
                RaisePropertyChanged("EmployeeName"); 
            }
        }
        public int EmployeeAge 
        {
            get
            {
                return employeeage;
            }
            set
            {
                employeeage = value;
                RaisePropertyChanged("EmployeeAge"); 
            }
        }
        public double EmployeeSalary
        {
            get
            {
                return employeesalary;
            }
            set
            {
                employeesalary = value;
                RaisePropertyChanged("EmployeeSalary"); 
            }
        }

        private void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
