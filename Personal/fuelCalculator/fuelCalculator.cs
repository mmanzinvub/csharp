using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuelCalculator
{
    public class fuelCalculator
    {
        public double fuelConsuption { get; set; }
        public int tripLength { get; set; }
        public double fuelPrice { get; set; }

        public double CalculateFuel()
        {
            return tripLength * fuelConsuption / 100;
        }

        public double CalculateCost()
        {
            return CalculateFuel() * fuelPrice;
        }
    }
}
