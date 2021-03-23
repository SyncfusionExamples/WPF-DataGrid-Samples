using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : NotificationObject
    {
        #region PrivateFields
        private string _name;
        private string _Id;
        private string _country;
        private double _number;
        #endregion

        #region Public Property
        /// <summary>
        /// Gets or Sets the Customer Name.
        /// </summary>
        public string customername
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                this.RaisePropertyChanged("CareOf");
            }
        }
        /// <summary>
        /// Gets or Sets the Customer Id.
        /// </summary>
        public string customerId
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
                this.RaisePropertyChanged("StreetToAddr");
            }
        }
        /// <summary>
        /// Gets or Sets the Country Details.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                this.RaisePropertyChanged("CityToAddr");
            }
        }

        /// <summary>
        /// Gets or Sets the Salary Details.
        /// </summary>
        public double salary
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                this.RaisePropertyChanged("StateToAddr");
            }
        }
        #endregion
    }
}
