using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_SfDataGrid
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
            for (int i = 0; i < 100000; i++)
            {
                var obj = new BusinessObjects()
                {
                    EmployeeId = i,
                    EmployeeName = "Sindhya" + i.ToString(),
                    EmployeeAge = 20,
                    EmployeeArea = "India",
                    EmployeeStatus = true,
                    EmployeeDesignation = "Senior Architect ",
                    EmployeeSalary = 1200,
                    ExperienceInMonth = 10,
                    EmployeeDOB = DateTime.Now,
                    EmployeeGender = "Female"
                };

                this.Add(obj);
            }
        }

    }
}
