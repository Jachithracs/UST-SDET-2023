using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CarInsurance : AbstractInsurancePolicy
    {
        public string? VehicleType { get; set; }
        public override double CalculatePremium()
        {
            if (VehicleType == "Audi")
            {
                PremiumAmount = PremiumAmount + 5000;
            }
            else if (VehicleType == "BMW")
            {
                PremiumAmount = PremiumAmount + 3000;
            }
            else
            {
                PremiumAmount = PremiumAmount + 1000;
            }
            return PremiumAmount;
        }
    }
}
