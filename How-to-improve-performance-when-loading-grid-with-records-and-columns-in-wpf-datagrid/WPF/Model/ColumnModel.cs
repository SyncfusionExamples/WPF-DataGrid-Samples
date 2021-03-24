using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SfDataGridDemo_sample
{
    public class ColumnModel : INotifyPropertyChanged
    {        
        public int column1 { get; set; }
        public int column2 { get; set; }        
        public string column3 { get; set; }
        public string column4 { get; set; }
        public string column5 { get; set; }

        //public string column6 { get; set; }
        //public string column7 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
        }
    }
}
