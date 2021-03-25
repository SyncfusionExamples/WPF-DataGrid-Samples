using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {             
        private ObservableCollection<Customers> _employeedetails;
        public ObservableCollection<Customers> EmployeeDetails
        {
            get
            {
                return _employeedetails;
            }
            set
            {
                _employeedetails = value;
                OnPropertyChanged("EmployeeDetails");
            }
        }
        private ObservableCollection<Employees> _employeedetails1;
        public ObservableCollection<Employees> EmployeeDetails1
        {
            get
            {
                return _employeedetails1;
            }
            set
            {
                _employeedetails1 = value;
                OnPropertyChanged("EmployeeDetails1");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            EmployeeDetails = new Model().PopulateCustomers(200);
            EmployeeDetails1 = new Model().PopulateEmployees(200); 
        }        
    }   
}
            
        
     

