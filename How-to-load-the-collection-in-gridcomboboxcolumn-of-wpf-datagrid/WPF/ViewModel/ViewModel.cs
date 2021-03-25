using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            stringName = new ObservableCollection<StringName>();
            stringName.Add(new StringName { Name = "one" });
            stringName.Add(new StringName { Name = "two" });
            stringName.Add(new StringName { Name = "three" });
            stringName.Add(new StringName { Name = "four" });
            stringName.Add(new StringName { Name = "five" });
            stringName.Add(new StringName { Name = "six" });
            stringName.Add(new StringName { Name = "seven" });
            stringName.Add(new StringName { Name = "eight" });
            stringName.Add(new StringName { Name = "nine" });

            orderlist = new ObservableCollection<Model>();
            orderlist.Add(new Model { Name = "Hanna Moos", City = "ALFKI", Country = "UK", SelectedName = this.StringName[0] });
            orderlist.Add(new Model { Name = "Lie", City = "London", Country = "Sweden", SelectedName = this.StringName[1] });
            orderlist.Add(new Model { Name = "Joseph", City = "BERGS", Country = "America", SelectedName = this.StringName[2] });
            orderlist.Add(new Model { Name = "Thomas Hardy", City = "BOTTM", Country = "Canada", SelectedName = this.StringName[3] });
            orderlist.Add(new Model { Name = "Thomas Hardy", City = "NY", Country = "Italy", SelectedName = this.StringName[4] });
            orderlist.Add(new Model { Name = "Laurence Lebihan", City = "ANTON", Country = "German", SelectedName = this.StringName[5] });
            orderlist.Add(new Model { Name = "Elizabeth Lincoln", City = "Berlin", Country = "America", SelectedName = this.StringName[6] });
            orderlist.Add(new Model { Name = "Martin Sommer", City = "CA", Country = "France", SelectedName = this.StringName[7] });
            orderlist.Add(new Model { Name = "Maria Anders", City = "Madrid", Country = "Mexico", SelectedName = this.StringName[8] });

        }
        private ObservableCollection<Model> orderlist;
        public ObservableCollection<Model> Orderlist
        {
            get
            {
                return orderlist;
            }
            set
            {
                orderlist = value;
                RaisePropertyChanged("Orderlist");
            }
        }
        private ObservableCollection<StringName> stringName;
        public ObservableCollection<StringName> StringName
        {
            get { return stringName; }
            set { StringName = value; }
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

    public class StringName
    {
        public StringName(string name) { this.Name = name; }
        public StringName() { }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
