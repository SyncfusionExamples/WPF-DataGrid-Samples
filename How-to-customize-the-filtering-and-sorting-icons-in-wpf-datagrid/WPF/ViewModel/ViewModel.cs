using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomizingGridHeaderCellIcon
{
    public class UserInfoViewModel : INotifyPropertyChanged, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public UserInfoViewModel()
        {
            UserDetails = new UserInfoRepository().GetUserDetails(20);
            
        }

        private ObservableCollection<UserInfo> userDetails;
        public ObservableCollection<UserInfo> UserDetails
        {
            get { return userDetails; }
            set { userDetails = value; RaisePropertyChanged("UserDetails"); }
        }

        public void Dispose()
        {
            if (UserDetails != null)
                UserDetails.Clear();
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
