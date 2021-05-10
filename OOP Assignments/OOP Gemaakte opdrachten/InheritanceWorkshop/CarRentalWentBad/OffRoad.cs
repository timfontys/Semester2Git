using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
   public class OffRoad : Car
    {
 
        public bool HasFourWheelDrive { get; private set; }

     
        public OffRoad(string manufacturer, string model,int buildYear, string licencePlate,bool hasFourWheelDrive) : base(manufacturer, model, buildYear, licencePlate)
        {
            HasFourWheelDrive = hasFourWheelDrive;
        }

        public override decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 170m;
            const decimal kmRate = 0.35m;

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

            string fourWheelDriveInfo;
            if (HasFourWheelDrive)
            {
                fourWheelDriveInfo = "With four wheel drive";
            }
            else
            {
                fourWheelDriveInfo = "Without four wheel drive";
            }

            return "Off Road: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + fourWheelDriveInfo;
        }
    }
}
