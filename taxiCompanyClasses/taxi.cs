using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiCompanyClasses
{
    class taxi
    {
        private string name;
        private int phoneNumber;
        private double pickupFee;
        private double ratePerKM;

        public taxi (string argsName, int argsPhoneNumber, double argsPickupFee, double argsRatePerKM)
        {
            name = argsName;
            phoneNumber = argsPhoneNumber;
            pickupFee = argsPickupFee;
            ratePerKM = argsRatePerKM;
        }

        public double CalculateCost(double Distance)
        {
            double cost = pickupFee + ratePerKM * Distance;
            return cost;
        }
    }
}
