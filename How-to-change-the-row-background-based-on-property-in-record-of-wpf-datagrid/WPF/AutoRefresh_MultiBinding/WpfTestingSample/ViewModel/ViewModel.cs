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
            this.ItemsCollection = emp;        
        }

        #endregion


        private ObservableCollection<BusinessObjects> itemsCollection;
        public ObservableCollection<BusinessObjects> ItemsCollection
        {
            get
            {
                return itemsCollection;
            }
            set
            {
                itemsCollection = value;
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

            BusinessObjects b = new BusinessObjects() { IsChecked=false, CountryCode = "NR",  EmployeeAge = 34, EmployeeArea = "101010", EmployeeSalary = 1.7, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, CountryCode = "NP", EmployeeAge = 43, EmployeeArea = "010101", EmployeeSalary = 2.5, ExperienceInMonth = 45, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() {  IsChecked = false, CountryCode = "NL", EmployeeAge = 42, EmployeeArea = "1222111", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() {  IsChecked = false, CountryCode = "NZ", EmployeeAge = 36, EmployeeArea = "011111", EmployeeSalary = 67000, ExperienceInMonth = 17, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() {IsChecked = false, CountryCode = "NI", EmployeeAge = 54, EmployeeArea = "111111", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() {IsChecked = false, CountryCode = "NE", EmployeeAge = 45, EmployeeArea = "11111111", EmployeeSalary = 90000, ExperienceInMonth = 14, EmployeeGender = "Female", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false,CountryCode = "NG", EmployeeAge = 48, EmployeeArea = "111111111", EmployeeSalary = 34567, ExperienceInMonth = 20, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
        }
    }



}
