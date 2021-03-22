
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailsViewDemo
{
    public class ShipCountries : List<string>
    {
        public ShipCountries()
        {
            var model = new OrderInfoRepository();
            this.AddRange(model.ShipCountries);
        }
    }
}
