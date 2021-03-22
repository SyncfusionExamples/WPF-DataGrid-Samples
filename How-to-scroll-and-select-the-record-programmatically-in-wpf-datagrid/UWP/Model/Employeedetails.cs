using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
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
            BusinessObjects b = new BusinessObjects() { EmployeeId = 1001, EmployeeName = "Mark", EmployeeAge = 22, EmployeeArea = "USA", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1002, EmployeeName = "Peter", EmployeeAge = 21, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1003, EmployeeName = "James", EmployeeAge = 20, EmployeeArea = "UAE", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1004, EmployeeName = "Oliver", EmployeeAge = 20, EmployeeArea = "USA", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1005, EmployeeName = "Robert", EmployeeAge = 22, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1006, EmployeeName = "Suji", EmployeeAge = 23, EmployeeArea = "UK", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1007, EmployeeName = "Mahesh", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1008, EmployeeName = "Ruby", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1009, EmployeeName = "Christain", EmployeeAge = 21, EmployeeArea = "India", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1010, EmployeeName = "Aravind", EmployeeAge = 20, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1011, EmployeeName = "Daniel", EmployeeAge = 22, EmployeeArea = "USA", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1012, EmployeeName = "Suhitha Azar", EmployeeAge = 21, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1013, EmployeeName = "Praveen", EmployeeAge = 20, EmployeeArea = "UAE", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1014, EmployeeName = "Robert", EmployeeAge = 22, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1015, EmployeeName = "Suji", EmployeeAge = 23, EmployeeArea = "UK", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1017, EmployeeName = "Mahesh", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1018, EmployeeName = "Ruby", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1019, EmployeeName = "Christain", EmployeeAge = 21, EmployeeArea = "India", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1020, EmployeeName = "Aravind", EmployeeAge = 20, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1021, EmployeeName = "Daniel", EmployeeAge = 22, EmployeeArea = "USA", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1022, EmployeeName = "Suhitha Azar", EmployeeAge = 21, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1023, EmployeeName = "Oliver", EmployeeAge = 20, EmployeeArea = "USA", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1024, EmployeeName = "Robert", EmployeeAge = 22, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1025, EmployeeName = "Suji", EmployeeAge = 23, EmployeeArea = "UK", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1026, EmployeeName = "Mahesh", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1027, EmployeeName = "Ruby", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1028, EmployeeName = "Christain", EmployeeAge = 21, EmployeeArea = "India", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1029, EmployeeName = "Aravind", EmployeeAge = 20, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1030, EmployeeName = "Daniel", EmployeeAge = 22, EmployeeArea = "USA", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1031, EmployeeName = "Suhitha Azar", EmployeeAge = 21, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1032, EmployeeName = "Praveen", EmployeeAge = 20, EmployeeArea = "UAE", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1033, EmployeeName = "Robert", EmployeeAge = 22, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1034, EmployeeName = "Suji", EmployeeAge = 23, EmployeeArea = "UK", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1035, EmployeeName = "Mahesh", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1036, EmployeeName = "Ruby", EmployeeAge = 22, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1037, EmployeeName = "Christain", EmployeeAge = 21, EmployeeArea = "India", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1038, EmployeeName = "Aravind", EmployeeAge = 20, EmployeeArea = "India", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1039, EmployeeName = "Daniel", EmployeeAge = 22, EmployeeArea = "USA", EmployeeStatus = false, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Male" };
            this.Add(b);
            b = new BusinessObjects() { EmployeeId = 1040, EmployeeName = "Suhitha Azar", EmployeeAge = 21, EmployeeArea = "UK", EmployeeStatus = true, EmployeeDesignation = "Syncfusion", EmployeeSalary = 1200, ExperienceInMonth = 10, EmployeeDOB = DateTime.Now, EmployeeGender = "Female" };
            this.Add(b);
        }
    }
}
