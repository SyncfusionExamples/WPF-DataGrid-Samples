using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    class Model :INotifyPropertyChanged
    {
        private int empID;

        public int EmployeeID
        {
            get { return empID; }
            set { empID = value; OnPropertyChanged("EmployeeID"); }
        }

        private string empName;

        public string EmployeeName
        {
            get { return empName; }
            set { empName = value; OnPropertyChanged("EmployeeName"); }
        }

        private int empAge;

        public int EmployeeAge
        {
            get { return empAge; }
            set { empAge = value; OnPropertyChanged("EmployeeAge"); }
        }

        private double salary;

        public double EmployeeSalary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("EmployeeSalary"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
