using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo
{
    class ViewModel
    {
        public ObservableCollection<Model> employeelist;

        public ViewModel()
        {

            employeelist = new ObservableCollection<Model>();

            employeelist.Add(new Model()
            {
                EmployeeID = 101,
                EmployeeName = "Martin",
                EmployeeAge = 25,
                EmployeeSalary = 20000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 102,
                EmployeeName = "Jacobs",
                EmployeeAge = 32,
                EmployeeSalary = 21000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 103,
                EmployeeName = "Thomas",
                EmployeeAge = 45,
                EmployeeSalary = 22000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 104,
                EmployeeName = "Markvin",
                EmployeeAge = 26,
                EmployeeSalary = 23000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 105,
                EmployeeName = "Michael",
                EmployeeAge = 29,
                EmployeeSalary = 24000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 106,
                EmployeeName = "Edison",
                EmployeeAge = 38,
                EmployeeSalary = 25000
            });
        }

        public ObservableCollection<Model> EmployeeDetails
        {
            get { return employeelist; }
            set { value = employeelist; }
        }
    }
}
