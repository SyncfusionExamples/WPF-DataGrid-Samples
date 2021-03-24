using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Syncfusion.UI.Xaml.Grid.Helpers;

namespace NullValue_Filtering
{  
    public class ViewModel
    {    
        #region properties

        ObservableCollection<dynamic> _orderCollectionDyn;

        public ObservableCollection<dynamic> OrderCollectionDyn
        {
            get
            {
                return _orderCollectionDyn = getDynamicGenratedItems();
            }
            set
            {
                _orderCollectionDyn = value;                
            }
                   
        }       

        #endregion

        #region generating functions

        private ObservableCollection<dynamic> getDynamicGenratedItems()
        {
          ObservableCollection<dynamic> dynamicItems = new ObservableCollection<dynamic>();

          for (int j = 0; j < 20; j++)
          {                

                dynamic data = new ExpandoObject();               

                data.OrderID = 100+j;

                data.CustomerName = GetCustomerName(j);

                if (j % 5 == 0)
                    data.CustomerID = null;
                else
                    data.CustomerID = 13 * j;                                             

                dynamicItems.Add(data);

          }

          return dynamicItems;

        }

        public string GetCustomerName(int value)
        {
            string customerName;

            return  customerName = "Name" + value;            
        }

        #endregion 
      }
}
