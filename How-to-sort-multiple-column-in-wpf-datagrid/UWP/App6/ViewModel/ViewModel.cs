using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GDCSource = GetRecords();
        }

        private ObservableCollection<Model> gdcsource;
        public ObservableCollection<Model> GDCSource
        {
            get
            {
                return gdcsource;
            }
            set
            {
                gdcsource = value;
            }
        }


        private ObservableCollection<Model> GetRecords()
        {
            var records = new ObservableCollection<Model>();
            records.Add(new Model() { EmployeeName = "Robert", EmployeeArea = "Torino", EmployeeDesignation = "Analysts", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Montreal", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 15000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Nancy", EmployeeArea = "Bracke", EmployeeDesignation = "Manager", EmployeeSalary = 27000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Andrew", EmployeeArea = "Kobenhavn", EmployeeDesignation = "SalesRepresentative", EmployeeSalary = 20500, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Arhus", EmployeeDesignation = "Vicepresident", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Steven", EmployeeArea = "Oulu", EmployeeDesignation = "SalesRepresentative", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Michael", EmployeeArea = "Torino", EmployeeDesignation = "salesmanager", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Lisboa", EmployeeDesignation = "Insidesalescoordinator", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Anne", EmployeeArea = "London", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 13500, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Aburt", EmployeeArea = "Geneve", EmployeeDesignation = "Businessmanager", EmployeeSalary = 16000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Tim", EmployeeArea = "Malaysia", EmployeeDesignation = "Mailclerk", EmployeeSalary = 10000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Caroline", EmployeeArea = "Caracas", EmployeeDesignation = "Receptionist", EmployeeSalary = 19000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Justin", EmployeeArea = "Lilly", EmployeeDesignation = "Marketingdirector", EmployeeSalary = 17000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Xavier", EmployeeArea = "Kobenhavn", EmployeeDesignation = "Marketingassociate", EmployeeSalary = 12000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Hork", EmployeeDesignation = "AdvertetisingSpecialist", EmployeeSalary = 15000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Antony", EmployeeArea = "Bern", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 43000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Aburt", EmployeeArea = "Geneve", EmployeeDesignation = "Businessmanager", EmployeeSalary = 10000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Tim", EmployeeArea = "Malaysia", EmployeeDesignation = "Mailclerk", EmployeeSalary = 10000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Caroline", EmployeeArea = "Caracas", EmployeeDesignation = "Receptionist", EmployeeSalary = 54000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Justin", EmployeeArea = "Lilly", EmployeeDesignation = "Marketingdirector", EmployeeSalary = 33000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Kobenhavn", EmployeeDesignation = "Marketingassociate", EmployeeSalary = 24000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Laurant", EmployeeArea = "Hork", EmployeeDesignation = "AdvertetisingSpecialist", EmployeeSalary = 18000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Antony", EmployeeArea = "Bern", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 12000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Xavier", EmployeeArea = "Kobenhavn", EmployeeDesignation = "Marketingassociate", EmployeeSalary = 30000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Laurant", EmployeeArea = "Hork", EmployeeDesignation = "AdvertetisingSpecialist", EmployeeSalary = 20000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Antony", EmployeeArea = "Bern", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 15000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Xavier", EmployeeArea = "Kobenhavn", EmployeeDesignation = "Marketingassociate", EmployeeSalary = 24000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Laurant", EmployeeArea = "Hork", EmployeeDesignation = "AdvertetisingSpecialist", EmployeeSalary = 18000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Antony", EmployeeArea = "Bern", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 12000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = null, EmployeeArea = "Kobenhavn", EmployeeDesignation = "Marketingassociate", EmployeeSalary = 30000, EmployeeGender = "FeMale" });
            records.Add(new Model() { EmployeeName = "Laurant", EmployeeArea = "Hork", EmployeeDesignation = "AdvertetisingSpecialist", EmployeeSalary = 20000, EmployeeGender = "Male" });
            records.Add(new Model() { EmployeeName = "Antony", EmployeeArea = "Bern", EmployeeDesignation = "SoftwareEngineer", EmployeeSalary = 15000, EmployeeGender = "Male" });
            return records;
        }
    }
}
