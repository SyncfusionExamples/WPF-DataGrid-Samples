using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel : NotificationObject
    {
        public ViewModel()
        {
            this.Model = records();
        }
        private ObservableCollection<Model> list;
        public ObservableCollection<Model> Model
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                this.RaisePropertyChanged("model");
            }
        }

        private ObservableCollection<Model> records()
        {
            list = new ObservableCollection<Model>();
            list.Add(new Model() { customername = "Alice", customerId = "AFRT", Country = "Beverton", salary = double.NegativeInfinity });
            list.Add(new Model() { customername = "Lawrence", customerId = "EDRT", Country = "Oregon", salary = 56784 });
            list.Add(new Model() { customername = "Bleso", customerId = "PIYG", Country = "Chicago", salary = double.PositiveInfinity });
            list.Add(new Model() { customername = "Abdul", customerId = "AWER", Country = "Oregon", salary = 75577 });
            list.Add(new Model() { customername = "Rahim", customerId = "CEDS", Country = "Chimir", salary = 86483 });
            list.Add(new Model() { customername = "Catho", customerId = "REWS", Country = "Boswha", salary = double.PositiveInfinity });
            list.Add(new Model() { customername = "Divo", customerId = "CEDR", Country = "Nile", salary = 4563839 });
            list.Add(new Model() { customername = "Charles", customerId = "PIRN", Country = "Johannesberg", salary = 56474 });
            list.Add(new Model() { customername = "Oliver", customerId = "CRED", Country = "Johann", salary = 04747 });
            list.Add(new Model() { customername = "Gathay", customerId = "DERF", Country = "Sheatu", salary = double.PositiveInfinity });
            list.Add(new Model() { customername = "Flintof", customerId = "TRED", Country = "Kigdom", salary = 65859 });
            list.Add(new Model() { customername = "Jack", customerId = "WERF", Country = "Olympia", salary = 85675 });
            list.Add(new Model() { customername = "John", customerId = "UYTE", Country = "Hosur", salary = double.NegativeInfinity });
            list.Add(new Model() { customername = "Bendo", customerId = "BTEF", Country = "Ramfo", salary = 54840 });
            list.Add(new Model() { customername = "Dinda", customerId = "BTEF", Country = "Hirew", salary = 70474 });
            list.Add(new Model() { customername = "John", customerId = "VRDD", Country = "Hirew", salary = double.NegativeInfinity });
            return list;
        }
    }

}

