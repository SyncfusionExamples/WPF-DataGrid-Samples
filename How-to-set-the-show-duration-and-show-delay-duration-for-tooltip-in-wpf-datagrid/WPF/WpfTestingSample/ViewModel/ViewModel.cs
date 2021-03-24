using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestingSample
{
    class ViewModel:INotifyPropertyChanged
    {
        EmployeeDetails emp = new EmployeeDetails();

        #region Constructor

        public ViewModel()
        {
            this.GDCSource = emp;
        }

        #endregion

        private ObservableCollection<BusinessObjects> gdcsource;
        public ObservableCollection<BusinessObjects> GDCSource
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


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        
    }

    #region GDCSource DataSource
    class EmployeeDetails : ObservableCollection<BusinessObjects>
    {
        Random rand = new Random();
        public EmployeeDetails()
        {
            PopulateCollection();
        }

        private void PopulateCollection()
        {
            this.Clear();

            for (int i = 0; i < 100000; i++)
            {
                BusinessObjects b = new BusinessObjects() { EmployeeName = "Mart", EmployeeAge = 45, EmployeeArea = "USA", EmployeeSalary = 33000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Peter", EmployeeAge = 35, EmployeeArea = "UK", EmployeeSalary = 5678, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "James", EmployeeAge = 42, EmployeeArea = "UAE", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Oliver",EmployeeAge = 36, EmployeeArea = "USA", EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Robert",EmployeeAge = 54, EmployeeArea = "India", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Suji", EmployeeAge = 45, EmployeeArea = "UK", EmployeeSalary = 90000, ExperienceInMonth = 10, EmployeeGender = "Female" };
                this.Add(b);
                b = new BusinessObjects() { EmployeeName = "Mahesh", EmployeeAge = 48, EmployeeArea = "UK", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male" };
                this.Add(b);             
            }

        }
    }

    #endregion
}
