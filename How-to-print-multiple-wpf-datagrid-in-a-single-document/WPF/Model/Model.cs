using SfDataGridDemo;
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
    public class Model : INotifyPropertyChanged
    {
        public Model() { }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        internal ObservableCollection<Customers> PopulateCustomers(int count)
        {
            Northwind northWind;
            ObservableCollection<Customers> customerCollection = new ObservableCollection<Customers>();
            string connectionString = string.Format(@"Data Source = {0}", "Northwind.sdf");
            northWind = new Northwind(connectionString);
            var customers = northWind.Customers.Skip(0).Take(15).ToList();
            foreach (var o in customers)
            {
                customerCollection.Add(o);
            }
            return customerCollection;
        }
        internal ObservableCollection<Employees> PopulateEmployees(int count)
        {
            Northwind northWind;
            ObservableCollection<Employees> employeesCollection = new ObservableCollection<Employees>();
            string connectionString = string.Format(@"Data Source = {0}", "Northwind.sdf");
            northWind = new Northwind(connectionString);
            var employees = northWind.Employees.Skip(0).Take(50).ToList();
            foreach (var o in employees)
            {
                employeesCollection.Add(o);
            }
            return employeesCollection;
        }
    }
}

      
    

