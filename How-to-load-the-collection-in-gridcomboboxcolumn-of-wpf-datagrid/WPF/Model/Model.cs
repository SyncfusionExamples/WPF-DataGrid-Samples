using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : INotifyPropertyChanged
    {
        private double numberDisplay;
        private string name;
        private string city;
        private string country;
        private StringName selectedName;

        public double NumberDisplay
        {
            get
            {
                return numberDisplay;
            }
            set
            {
                numberDisplay = value;
                RaisePropertyChanged("NumberDisplay");
            }
        }
        public string Name
        {
            get 
            { 
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        public string City
        {
            get 
            { 
                return city; 
            }
            set
            {
                city = value; 
                RaisePropertyChanged("City");
            }
        }
        public string Country
        {
            get 
            {
                return country;
            }
            set
            {
                country = value;
                RaisePropertyChanged("Country");
            }
        }
        public StringName SelectedName
        {
            get 
            { 
                return selectedName; 
            }
            set
            {
                selectedName = value;
                RaisePropertyChanged("SelectedName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string Order)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Order));
            }
        }
    }
}
