using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class Truck : Car
    {
        
        public int CargoSpace { get; private set; }
        public int MaxWeight { get; private set; }


        public Truck(string manufacturer, string model, int buildYear, string licencePlate, int cargoSpace, int maxWeight) : base(manufacturer, model, buildYear, licencePlate)
        {
            CargoSpace = cargoSpace;
            MaxWeight = maxWeight;
        }

        public override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 400m;
            const decimal kmRate = 0.39m;

            return (dayRate * daysRented) + (kilometersDriven * kmRate);
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

            return "Truck: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + CargoSpace
                + ", " + MaxWeight;
        }
    }
}
