using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                EmployeeName = "Jacobs",
                EmployeeAge = 25,
                EmployeeSalary = 20000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 102,
                EmployeeName = "Edison",
                EmployeeAge = 32,
                EmployeeSalary = 21000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 103,
                EmployeeName = "Markswille",
                EmployeeAge = 45,
                EmployeeSalary = 22000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 104,
                EmployeeName = "Antony",
                EmployeeAge = 26,
                EmployeeSalary = 23000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 105,
                EmployeeName = "Bergius",
                EmployeeAge = 29,
                EmployeeSalary = 24000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 106,
                EmployeeName = "Thomas",
                EmployeeAge = 38,
                EmployeeSalary = 25000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 107,
                EmployeeName = "Martin",
                EmployeeAge = 32,
                EmployeeSalary = 35000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 108,
                EmployeeName = "Christopher",
                EmployeeAge = 32,
                EmployeeSalary = 34000
            });
            employeelist.Add(new Model()
            {
                EmployeeID = 109,
                EmployeeName = "Bradman Toy",
                EmployeeAge = 38,
                EmployeeSalary = 35000
            });
        }

        public ObservableCollection<Model> EmployeeDetails
        {
            get { return employeelist; }
            set { value = employeelist; }
        }
    }
}

        
