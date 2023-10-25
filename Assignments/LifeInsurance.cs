using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LifeInsurance : AbstractInsurancePolicy
    {
        public int Age { get; set; }
        public override double CalculatePremium()
        {
            if(Age < 60)
            {
                PremiumAmount = PremiumAmount + 10000;
            }
            else
            {
                PremiumAmount = PremiumAmount + 5000;
            }
            return PremiumAmount;
        }
    }
}
