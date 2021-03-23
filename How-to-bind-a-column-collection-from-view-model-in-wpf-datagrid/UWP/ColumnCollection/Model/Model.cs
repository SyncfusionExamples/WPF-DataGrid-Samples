using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo.Model
{
 public class BusinessObjects 
    {
        private string _CountryCode;

        public string CountryCode
        {
            get { return _CountryCode; }
            set { _CountryCode = value;}
        }
        private bool isChecked = false;

        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value;}
        }

        private string _ename;
        public string EmployeeName
        {
            get{ return _ename; }
            set{_ename = value; }
        }

        private int _eage;
        public int EmployeeAge
        {
            get{ return _eage;}
            set{ _eage = value;}
        }

        private string _earea;
        public string EmployeeArea
        {
            get{ return _earea;}
            set{ _earea = value;}
        }

        private string _egender;
        public string EmployeeGender
        {
            get { return _egender;}
            set {_egender = value;}
        }

        private int _eExpInMonth;
        public int ExperienceInMonth
        {
            get{ return _eExpInMonth;}
            set{ _eExpInMonth = value;}
        }

        private double _esalary;
        public double EmployeeSalary
        {
            get{ return _esalary;}
            set{ _esalary = value;}
        }

        private DateTime _edatetime;
        public DateTime EmployeeDate
        {
            get { return _edatetime;}
            set {_edatetime = value;}
        }

        private string empinfo;
        public string EmployeeInfo
        {
            get { return empinfo; }
            set { empinfo = value;}
        }
    }
}
