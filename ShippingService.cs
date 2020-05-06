using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV5
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService()
        {
            this.pricePerKg = 2.5;
        }

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }

        public double GetShippingServicePrice(IShipable package)
        {
            return package.Weight * pricePerKg;
        }

    }
}
