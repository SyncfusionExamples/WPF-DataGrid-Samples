using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel:INotifyPropertyChanged
    {
        public EmployeeInfoRepository respository
        {
            get;
            set;
        }
        public int Count = 15;
        public List<string> NameList { get; set; }
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
            NameList = new List<string>();
            NameList.Add("Sean Jacobson");
            NameList.Add("Phyllis Allen");
            NameList.Add("Marvin Allen");
            respository = new EmployeeInfoRepository();
            Emp = respository.GetEmployeesDetails(Count);
            DisplayValue = "USA";
        }


        private string displayValue;

        public string DisplayValue
        {
            get { return displayValue; }
            set { displayValue = value; RaisePropertyChanged("DisplayValue"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
