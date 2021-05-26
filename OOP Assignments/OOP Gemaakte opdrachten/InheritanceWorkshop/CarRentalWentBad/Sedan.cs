using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class Sedan : Car
    {
        public bool HasTowbar { get; private set; }

        public Sedan(string manufacturer, string model, int buildYear, string licencePlate, bool hasTowbar) : base(manufacturer, model, buildYear, licencePlate)
        {
            HasTowbar = hasTowbar;
        }

        public override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 80m;
            const decimal kmRate = 0.19m;
            decimal towbarDayRate;
            if (HasTowbar)
            {
                towbarDayRate = 5m;
            }
            else
            {
                towbarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (towbarDayRate * daysRented);
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

            string towbarInfo;
            if (HasTowbar)
            {
                towbarInfo = "with towbar";
            }
            else
            {
                towbarInfo = "without towbar";
            }


            return "Sedan: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + towbarInfo;
        }
    }
}
