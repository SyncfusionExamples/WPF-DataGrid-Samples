using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel: NotificationObject
    {
        public EmployeeInfoRepository respository
        {
            get;
            set;
        }
        public int Count = 500;
        private ObservableCollection<Employee> emp;
        public ObservableCollection<Employee> Emp
        {
            get
            {
                return emp;
            }
            set
            {
                emp = value;
            }
        }
        public ViewModel()
        {
            respository = new EmployeeInfoRepository();
            Emp = respository.GetEmployeesDetails(Count);
        }    
        
    }
}
