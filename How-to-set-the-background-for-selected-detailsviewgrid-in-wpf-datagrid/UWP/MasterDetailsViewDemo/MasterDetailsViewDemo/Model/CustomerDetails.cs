using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsViewDemo
{
    public class Customers : List<string>
    {
        public Customers()
        {
            var model = new OrderInfoRepository();
            this.AddRange(model.Customers);
        }
    }
}
