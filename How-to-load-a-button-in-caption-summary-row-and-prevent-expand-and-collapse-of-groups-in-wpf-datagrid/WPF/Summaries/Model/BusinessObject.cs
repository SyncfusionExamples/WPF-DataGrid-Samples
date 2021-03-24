using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummariesDemo
{
    public class BusinessObjects
    {
        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        private string _ename;
        public string EmployeeName
        {
            get { return _ename; }
            set { _ename = value; }
        }

        private string _earea;
        public string EmployeeArea
        {
            get { return _earea; }
            set { _earea = value; }
        }

        private string _egender;
        public string EmployeeGender
        {
            get { return _egender; }
            set { _egender = value; }
        }

        private int _eExpInMonth;
        public int ExperienceInMonth
        {
            get { return _eExpInMonth; }
            set { _eExpInMonth = value; }
        }

        private double _esalary;
        public double EmployeeSalary
        {
            get { return _esalary; }
            set { _esalary = value; }
        }

        private DateTime joiningDate;
        public DateTime JoiningDate
        {
            get { return joiningDate; }
            set { joiningDate = value; }
        }
    }
}
