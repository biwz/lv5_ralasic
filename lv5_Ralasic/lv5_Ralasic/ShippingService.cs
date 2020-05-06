using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Ralasic
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }

        public double TotalShippingCost(IShipable item)
        {
            return item.Weight * this.pricePerKg;
        }
    }
}
