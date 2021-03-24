using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SfDataGridDemo
{
    public class ViewModel 
    {       
        public ViewModel()
        {                       
            GDCSource = new List<Model>();
            Country = new List<Model1>();
            _country = new List<Model1>()
            {
                new Model1() { Country = "NAURU",CountryCode="NA"},
                new Model1() { Country = "NEPAL",CountryCode="US"},
                new Model1() { Country = "NETHERLANDS",CountryCode="NB"},
                new Model1() { Country = "NETHERLANDS ANTILLES",CountryCode="NA"},
                new Model1() { Country = "NEW CALEDONIA",CountryCode="NA"},
                new Model1() { Country = "NEW ZEALAND",CountryCode="NA"},
                new Model1() { Country = "NICARAGUA",CountryCode="NS"},               

            };
            this.gdcsource = new List<Model>();
            
            this.gdcsource.Add(new Model() { EmployeeName = "Mart",CountryCode="NA", EmployeeAge = 45,  EmployeeSalary = 33000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            this.gdcsource.Add(new Model() { EmployeeName = "Peter", CountryCode = "US", EmployeeAge = 35, EmployeeSalary = 5678, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
            this.gdcsource.Add(new Model() { EmployeeName = "James", CountryCode = "NB", EmployeeAge = 42, EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
            this.gdcsource.Add(new Model() { EmployeeName = "Oliver", CountryCode = "NA", EmployeeAge = 36, EmployeeSalary = 67000, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            this.gdcsource.Add(new Model() { EmployeeName = "Robert", CountryCode = "NA", EmployeeAge = 54, EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = false });
            this.gdcsource.Add(new Model() { EmployeeName = "Suji", CountryCode = "NA", EmployeeAge = 45 , EmployeeSalary = 90000, ExperienceInMonth = 10, EmployeeGender = "Female", EmployeeDate = DateTime.Now, Review = true });
            this.gdcsource.Add(new Model() { EmployeeName = "Mahesh", CountryCode = "NS", EmployeeAge = 48 , EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now, Review = true });
            InitialiseProductOptionsView();
        }      
        public ICollectionView ProductsView { get; private set; }
        public ICollectionView Employee { get; private set; }
        private void InitialiseProductOptionsView()
        {
            Employee = CollectionViewSource.GetDefaultView(GDCSource);
            ProductsView = CollectionViewSource.GetDefaultView(Country);
        }

        private List<Model> gdcsource;
        public List<Model> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                this.gdcsource = value;
                
            }
        }
        private List<Model1> _country;
        public List<Model1> Country
        {
            get
            {
                return _country;
            }
            set
            {
               this. _country = value;
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }   
}
            
        
     

