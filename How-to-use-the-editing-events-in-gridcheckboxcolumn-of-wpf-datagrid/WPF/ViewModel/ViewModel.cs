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
                Model b = new Model() { EmployeeName = "Mart", EmployeeAge = 45, EmployeeArea = "USA", EmployeeSalary = 33000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false };
                this.Add(b);
                b = new Model() { EmployeeName = "Peter", EmployeeAge = 35, EmployeeArea = "UK", EmployeeSalary = 5678, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true };
                this.Add(b);
                b = new Model() { EmployeeName = "James", EmployeeAge = 42, EmployeeArea = "UAE", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true };
                this.Add(b);
                b = new Model() { EmployeeName = "Oliver", EmployeeAge = 36, EmployeeArea = "USA", EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false };
                this.Add(b);
                b = new Model() { EmployeeName = "Robert", EmployeeAge = 54, EmployeeArea = "India", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false };
                this.Add(b);
                b = new Model() { EmployeeName = "Suji", EmployeeAge = 45, EmployeeArea = "UK", EmployeeSalary = 90000, ExperienceInMonth = 10, EmployeeGender = "Female", EmployeeDate = DateTime.Now, Review = true };
                this.Add(b);
                b = new Model() { EmployeeName = "Mahesh", EmployeeAge = 48, EmployeeArea = "UK", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true };
                this.Add(b);
            }
        }
    }
}
            
        
     

