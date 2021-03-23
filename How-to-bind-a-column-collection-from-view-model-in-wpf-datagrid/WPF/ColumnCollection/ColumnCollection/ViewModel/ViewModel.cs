using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnChooserDemo
{
    public class ViewModel
    {
        EmployeeDetails employeeDetails = new EmployeeDetails();
        private ObservableCollection<BusinessObjects> itemsCollection;
        private Columns sfGridColumns;

        public ViewModel()
        {
            SetSfGridColumns();
            this.ItemsCollection = employeeDetails;
        }

        public ObservableCollection<BusinessObjects> ItemsCollection
        {
            get { return itemsCollection; }
            set { itemsCollection = value;}
        }

        public Columns SfGridColumns
        {
            get { return sfGridColumns; }
            set { this.sfGridColumns = value; }
        }

        protected void SetSfGridColumns()
        {
            this.sfGridColumns = new Columns();
            sfGridColumns.Add(new GridTextColumn() { MappingName = "EmployeeName" });
            sfGridColumns.Add(new GridTextColumn() { MappingName = "EmployeeAge" });
            sfGridColumns.Add(new GridTextColumn() { MappingName = "EmployeeSalary" });
            sfGridColumns.Add(new GridTextColumn() { MappingName = "ExperienceInMonth" });
        }
    }

    public class EmployeeDetails : ObservableCollection<BusinessObjects>
    {
        Random rand = new Random();
        public EmployeeDetails()
        {
            PopulateCollection();
        }

        private void PopulateCollection()
        {
            this.Clear();
            BusinessObjects b = new BusinessObjects() { IsChecked = false, EmployeeName = "Mart", CountryCode = "NR", EmployeeAge = 34, EmployeeArea = "101010", EmployeeSalary = 1.7, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "Peter", CountryCode = "NP", EmployeeAge = 43, EmployeeArea = "010101", EmployeeSalary = 2.5, ExperienceInMonth = 45, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "James", CountryCode = "NL", EmployeeAge = 42, EmployeeArea = "1222111", EmployeeSalary = 18700, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "Oliver", CountryCode = "NZ", EmployeeAge = 36, EmployeeArea = "011111", EmployeeSalary = 67000, ExperienceInMonth = 17, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "Robert", CountryCode = "NI", EmployeeAge = 54, EmployeeArea = "111111", EmployeeSalary = 34567, ExperienceInMonth = 10, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "Suji", CountryCode = "NE", EmployeeAge = 45, EmployeeArea = "11111111", EmployeeSalary = 90000, ExperienceInMonth = 14, EmployeeGender = "Female", EmployeeDate = DateTime.Now };
            this.Add(b);
            b = new BusinessObjects() { IsChecked = false, EmployeeName = "Mahesh", CountryCode = "NG", EmployeeAge = 48, EmployeeArea = "111111111", EmployeeSalary = 34567, ExperienceInMonth = 20, EmployeeGender = "Male", EmployeeDate = DateTime.Now };
            this.Add(b);
        }
    }
}
