using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfDataGridDemo.Model;

namespace SfDataGridDemo
{
    public class Viewmodel : INotifyPropertyChanged
    {
        public Viewmodel()
        {
            var data = new ObservableCollection<BusinessObjects>();

            for (int i = 0; i < 5; i++)
            {
                data.Add(new BusinessObjects() { EmployeeName = "Ragul", EmployeeArea = "US", EmployeeCity = "Sader", EmployeeSalary = 50000 });
                data.Add(new BusinessObjects() { EmployeeName = "Peter", EmployeeArea = "Russia", EmployeeCity = "Jiaoa", EmployeeSalary = 10000 });
                data.Add(new BusinessObjects() { EmployeeName = "John", EmployeeArea = "Putan", EmployeeCity = "Asder", EmployeeSalary = 20000 });
                data.Add(new BusinessObjects() { EmployeeName = "Iman", EmployeeArea = "Pakistan", EmployeeCity = "Kiouae", EmployeeSalary = 30000 });
                data.Add(new BusinessObjects() { EmployeeName = "George", EmployeeArea = "Barma", EmployeeCity = "Qwesde", EmployeeSalary = 40000 });
                data.Add(new BusinessObjects() { EmployeeName = "parthi", EmployeeArea = "Ingland", EmployeeCity = "Bhyui", EmployeeSalary = 50000 });
                data.Add(new BusinessObjects() { EmployeeName = "Sam", EmployeeArea = "US", EmployeeCity = "Sader", EmployeeSalary = 50000 });
                data.Add(new BusinessObjects() { EmployeeName = "Anderson", EmployeeArea = "Russia", EmployeeCity = "Jiaoa", EmployeeSalary = 10000 });
                data.Add(new BusinessObjects() { EmployeeName = "Wilson", EmployeeArea = "Putan", EmployeeCity = "Asder", EmployeeSalary = 20000 });
                data.Add(new BusinessObjects() { EmployeeName = "Smith", EmployeeArea = "Pakistan", EmployeeCity = "Kiouae", EmployeeSalary = 30000 });
                data.Add(new BusinessObjects() { EmployeeName = "Jack", EmployeeArea = "Barma", EmployeeCity = "Qwesde", EmployeeSalary = 40000 });
                data.Add(new BusinessObjects() { EmployeeName = "Janwat", EmployeeArea = "Ingland", EmployeeCity = "Bhyui", EmployeeSalary = 50000 });
            }
            this.gdcsource = data;
            SelectedItem = this.gdcsource[22];
        }

        private object _selectedItem;
        public object SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> ItemSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
                RaisePropertyChanged("ItemSource");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
