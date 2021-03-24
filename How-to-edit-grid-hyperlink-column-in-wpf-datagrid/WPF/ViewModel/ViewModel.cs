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
        private ObservableCollection<Model> _employeedetails;
        public ObservableCollection<Model> EmployeeDetails
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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            _employeedetails = new ObservableCollection<Model>();
           this.generate();
        }
        public void generate()
        {
            _employeedetails.Add(new Model() { EmployeeName = "Oliver", EmployeeAge = 36, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            _employeedetails.Add(new Model() { EmployeeName = "James", EmployeeAge = 42, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
            _employeedetails.Add(new Model() { EmployeeName = "Peter", EmployeeAge = 35, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 5678, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
            _employeedetails.Add(new Model() { EmployeeName = "Mart", EmployeeAge = 45, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 33000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            _employeedetails.Add(new Model() { EmployeeName = "Oliver", EmployeeAge = 36, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            _employeedetails.Add(new Model() { EmployeeName = "Suji", EmployeeAge = 45, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 90000, ExperienceInMonth = 10, EmployeeGender = "Female", EmployeeDate = DateTime.Now, Review = true });
            _employeedetails.Add(new Model() { EmployeeName = "Mahesh", EmployeeAge = 48, Country = "India", HyperLink = "https://india.gov.in/", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
        }
    }   
}
            
        
     

