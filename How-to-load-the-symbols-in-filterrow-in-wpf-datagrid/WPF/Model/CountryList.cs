using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_SfDataGrid
{
    public class CountriesList : INotifyPropertyChanged
    {
        #region Properties

        private string serialNumber;
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
                OnPropertyChanged("Serial Number");
            }
        }

        private string countryName;
        public string COUNTRY
        {
            get
            {
                return countryName;
            }
            set
            {
                countryName = value;
                OnPropertyChanged("Country Name");
            }
        }

        private string countryCapital;
        public string CAPITAL
        {
            get
            {
                return countryCapital;
            }
            set
            {
                countryCapital = value;
                OnPropertyChanged("Country Capital");
            }
        }

        private string officialName;
        public string OFFICIALNAME
        {
            get
            {
                return officialName;
            }
            set
            {
                officialName = value;
                OnPropertyChanged("Official Name");
            }
        }

        private string location;
        public string LOCATION
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        private string language;
        public string LANGUAGE
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
                OnPropertyChanged("Language");
            }
        }

        private string currency;
        public string CURRENCY
        {
            get
            {
                return currency;
            }
            set
            {
                currency = value;
                OnPropertyChanged("Currency");
            }
        }

        #endregion

        #region Ctor

        public CountriesList()
        {

        }

        public CountriesList(string _serialNumber, string _countryName, string _countryCapital, string _officialName, string _location, string _language, string _currency)
        {
            this.serialNumber = _serialNumber;
            this.countryName = _countryName;
            this.countryCapital = _countryCapital;
            this.officialName = _officialName;
            this.location = _location;
            this.language = _language;
            this.currency = _currency;
        }

        #endregion

        #region INotifyEventChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
