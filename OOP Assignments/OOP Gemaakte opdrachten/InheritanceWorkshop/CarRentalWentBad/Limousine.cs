using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class Limousine : Car
    {
        public bool HasMinibar { get; private set; }
        public Limousine(string manufacturer, string model, int buildYear, string licencePlate, bool hasMiniBar) : base(manufacturer, model, buildYear, licencePlate)
        {
            HasMinibar = hasMiniBar;
        }

        public override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 200m;
            const decimal kmRate = 0.25m;
            decimal minibarDayRate;
            if (HasMinibar)
            {
                minibarDayRate = 20m;
            }
            else
            {
                minibarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (minibarDayRate * daysRented);
        }

        public override string ToString()
        {
            string availableInfo;
            if (IsAvailable)
            {
                availableInfo = "available";
            }
            else
            {
                availableInfo = "not available";
            }

            string minibarInfo;
            if (HasMinibar)
            {
                minibarInfo = "with mini bar";
            }
            else
            {
                minibarInfo = "without mini bar";
            }


            return "Limousine: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + minibarInfo;
        }
    }
}
