using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class DynamicModel : INotifyPropertyChanged
    {
        public Dictionary<string, object> data;

        public event PropertyChangedEventHandler PropertyChanged;

        public Dictionary<string, object> Values
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Values"));
            }

        }
        public DynamicModel()
        {
            this.data = new Dictionary<string, object>();

        }
    }
}
