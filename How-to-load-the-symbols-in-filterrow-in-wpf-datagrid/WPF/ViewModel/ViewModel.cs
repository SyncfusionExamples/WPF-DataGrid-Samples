using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance_SfDataGrid
{
    public class ViewModel : INotifyPropertyChanged
    {
        private EmployeeDetails itemSource;

        public EmployeeDetails ItemSource
        {
            get
            {
                return this.itemSource;
            }
        }

        public ViewModel()
        {
            this.itemSource = new EmployeeDetails();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String PropertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
