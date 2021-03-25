using SfDataGridDemo;
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
        EmployeeDetails emp = new EmployeeDetails();


        public ViewModel()
        {
            this.GDCSource = emp;
        }

        private ObservableCollection<Model> gdcsource;
        public ObservableCollection<Model> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
                OnPropertyChanged("GDCSource");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public class EmployeeDetails : ObservableCollection<Model>
    {
        Random rand = new Random();
        public EmployeeDetails()
        {
            PopulateCollection();
        }

        private void PopulateCollection()
        {
            this.Clear();

            for (int i = 0; i < 2; i++)
            {
                Model b = new Model() { EmployeeName = "Mart", EmployeeAge = 45, Id = 101, ShowCellIcon = true, EmployeeGender = "Male", CusId = 1 };
                this.Add(b);
                b = new Model() { EmployeeName = "Peter", EmployeeAge = 35, Id = 102, ShowCellIcon = false, EmployeeGender = "Male", CusId = 2 };
                this.Add(b);
                b = new Model() { EmployeeName = "James", EmployeeAge = 42, Id = 103, ShowCellIcon = true, EmployeeGender = "Male", CusId = 3 };
                this.Add(b);
                b = new Model() { EmployeeName = "Oliver", EmployeeAge = 36, Id = 104, ShowCellIcon = true, EmployeeGender = "Male", CusId = 4 };
                this.Add(b);
                b = new Model() { EmployeeName = "Robert", EmployeeAge = 54, Id = 105, ShowCellIcon = true, EmployeeGender = "Male", CusId = 5 };
                this.Add(b);
                b = new Model() { EmployeeName = "Suji", EmployeeAge = 45, Id = 106, ShowCellIcon = true, EmployeeGender = "Female", CusId = 6 };
                this.Add(b);
                b = new Model() { EmployeeName = "Mahesh", EmployeeAge = 48, Id = 107, ShowCellIcon = false, EmployeeGender = "Male", CusId = 7 };
                this.Add(b);
            }
        }
    }
}
