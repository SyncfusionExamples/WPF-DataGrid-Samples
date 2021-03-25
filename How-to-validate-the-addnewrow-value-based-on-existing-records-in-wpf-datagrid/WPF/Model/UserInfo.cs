using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class UserInfo : INotifyPropertyChanged
    {
        #region Fields
        private int userId;
        private string name;
        private DateTime dateofBirth;
        private string contactNo;
        private string city;
        private int salary;
        #endregion

        #region Properties

        public int UserId
        {
            get { return userId; }
            set { userId = value; OnPropertyChanged("UserId"); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; OnPropertyChanged("DateofBirth"); }
        }

        [StringLength(10, ErrorMessage = "Invalid Contact No, please enter correct contact number")]
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; OnPropertyChanged("ContactNo"); }
        }

        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("City"); }
        }

        [Range(25000, 30000, ErrorMessage = "Invalid Salary, please enter correct salary amount")]
        public int Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
