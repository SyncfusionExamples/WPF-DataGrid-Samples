using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ProductInfo
    {
        int orderId;
        string productName;

        public int OrderID
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

    }
}
